using InputFunNullifier.Controllers;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace InputFunNullifier.Effects.BuiltIn
{
    public class InputDelay : Effect
    {
        volatile InputList inputList;

        //TODO: add settings and twitch commands

        int delay = 0;
        public int Delay => delay;
        int curDelTmr = 0;

        object lockObj = new object();
        volatile bool updating = false;
        public override bool Updatable => true;

        Timer inputGrabTimer = null;

        public int MsTick { get; set; } = 15;


        public InputDelay(int delayListSize = 1024)
        {
            inputList = new InputList(delayListSize);
        }

        public override void Activate()
        {
            inputGrabTimer = new Timer(MsTick);
            inputGrabTimer.Elapsed += InputGrabTimer_Elapsed;
            inputGrabTimer.Enabled = true;
            inputGrabTimer.Start();
            updating = false;
        }

        public override void Deactivate()
        {
            if (inputGrabTimer != null)
            {
                inputGrabTimer.Stop();
                inputGrabTimer.Enabled = false;
                inputGrabTimer.Elapsed -= InputGrabTimer_Elapsed;
                inputGrabTimer.Dispose();
                inputGrabTimer = null;
            }
            updating = false;

        }

        private void InputGrabTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //RecieveData
            if (!updating)
            {
                updating = true;
                if (CtlrManager.InputController != null && CtlrManager.OutputController != null)
                {
                    //CtlrManager.InputController.Update();
                    RecieveData(CtlrManager.InputController.State);

                    //TODO: remove
                    Update(MsTick);
                }
                updating = false;

            }
        }

        public void ChangeDelay(int ndel)
        {
            delay = ndel;
            if (ndel < delay)
            {
                lock (lockObj)
                {
                    inputList.Reset();
                }
                if (curDelTmr > ndel) curDelTmr = ndel;
            }
        }

        public void RecieveData(Gamepad dat)
        {
            //lock (lockObj)
            //{
                //Inputs.Enqueue(dat);
            //if (delay > 0)
            //{
                inputList.AddInput(dat, delay);
            //}
            //}
        }

        public override void Update(int dtMs)
        {
            //lock (lockObj)
            //{

            if (CtlrManager.InputController != null && CtlrManager.OutputController != null)
            {
                CtlrManager.InputController.Update();

                if (delay > 0)
                {
                    RecieveData(CtlrManager.InputController.State);
                    Gamepad? cycleState = inputList.DoCycle(dtMs);
                    if (cycleState != null)
                    {
                        CtlrManager.OutputController?.SetState(cycleState.Value);
                        //TODO: SUBMIT REPORT IN CORE
                        CtlrManager.OutputController.SubmitReport();
                        //TODO: REMOVE
                        //InputUpdated?.Invoke();
                    }
                }
                else
                {
                    CtlrManager.OutputController?.SetState(CtlrManager.InputController.State);
                    //TODO: SUBMIT REPORT IN CORE
                    CtlrManager.OutputController.SubmitReport();
                    //TODO: REMOVE/MOVE TO CORE
                    
                }
            }
            //}
        }
    }

    //TODO: move to own file
    public class InputList
    {
        public InputTimed[] inputList;
        int curInd = 0;

        public InputList(int capSize = 1024)
        {
            inputList = new InputTimed[capSize];
        }

        private InputTimed FindFirstFree()
        {
            for (int j = 0; j < curInd; j++)
            {
                if (!inputList[j].inUse) return inputList[j];
            }
            //else
            return null;
        }

        public void AddInput(Gamepad dat, int delay)
        {
            InputTimed t = FindFirstFree();
            if (t == null)
            {
                AddOverflow(dat, delay);
            }
            else
            {
                t.Reuse(delay, dat);
            }
        }

        public void AddOverflow(Gamepad dat, int delay)
        {
            if (curInd >= inputList.Length - 1)
            {
                inputList[0].Reuse(delay, dat);
            }
            else
            {
                inputList[curInd] = new InputTimed(delay, dat);
                curInd++;
            }
        }

        public Gamepad? DoCycle(int dt)
        {
            Gamepad? ret = null;
            //Might do multithreaded
            for (int j = 0; j < curInd; j++)
            {
                bool r = inputList[j].TimeCheck(dt);
                if (r)
                {
                    //should only be one
                    ret = inputList[j].data;
                }

                //Tiny bit of cleanup
                if (j == curInd - 1)
                {
                    if (!inputList[j].inUse)
                    {
                        curInd--;
                    }
                }
            }

            return ret;
        }

        public void Reset()
        {
            for (int j = 0; j < curInd; j++)
            {
                inputList[j].inUse = false;
            }
            curInd = 0;
        }

    }

    //TODO: move to own file
    public class InputTimed
    {
        public bool inUse;
        public int timerLeft;

        public Gamepad data;

        public InputTimed(int time, Gamepad dat)
        {
            inUse = true;
            timerLeft = time;
            data = dat;
        }

        public void Reuse(int time, Gamepad dat)
        {
            inUse = true;
            timerLeft = time;
            data = dat;
        }

        /// <summary>
        /// Returns true if data should be sent
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool TimeCheck(int dt)
        {
            if (!inUse)
            {
                return false;
            }

            timerLeft -= dt;
            if (timerLeft <= 0)
            {
                inUse = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
