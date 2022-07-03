using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using InputFunNullifier;
using InputFunNullifier.Controllers;
using InputFunNullifier.Effects;
using InputFunNullifier.Effects.BuiltIn;
using SharpDX.XInput;
using System.Timers;

namespace InputFunDisp
{
    public partial class InputFunForm : Form
    {

        XInputController input = null;
        XInputController output = null;

        FunController funOutput = null;
        InputDelay delay = null;

        System.Timers.Timer mainLoop;

        public InputFunForm()
        {
            InitializeComponent();

            var ctlrs = InputFunNullifier.CtlrManager.GetAllControllers().Select(x => (int)x.UserIndex).ToArray();
            foreach (var ctlr in ctlrs)
            {
                Console.WriteLine($"Available Controllers: {ctlr}");
            }
            bStartDelay.Enabled = false;

            this.DoubleBuffered = true;
            this.FormClosing += InputFunForm_FormClosing;
        }

        private void InputFunForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CtlrManager.ShutDown();
            StopInputDebug();
        }

        private void UpdateJoyDisp(Control cL, Control cR, XInputController dat)
        {
            float lxL = dat.leftThumb.x;
            float lyL = dat.leftThumb.y;
            float lxR = dat.rightThumb.x;
            float lyR = dat.rightThumb.y;

            float w2L = (cL.Parent.Width / 2);
            float h2L = (cL.Parent.Height / 2);
            float w2R = (cR.Parent.Width / 2);
            float h2R = (cR.Parent.Height / 2);

            cL.Location = new System.Drawing.Point((int)(w2L + (w2L * lxL) - cL.Width / 2), (int)(h2L + (h2L * lyL) - cL.Height / 2));
            cR.Location = new System.Drawing.Point((int)(w2R + (w2R * lxR) - cR.Width / 2), (int)(h2R + (h2R * lyR) - cR.Height / 2));
        }

        
        private void bStartDelay_Click(object sender, EventArgs e)
        {
            bStartDelay.Enabled = false;
            CtlrManager.InputController = input;
            CtlrManager.OutputController = funOutput;
            delay = new InputDelay(2048);
            delay.ChangeDelay((int)nmDelay.Value);
            Core.InputUpdated += DisplayControllerStatus;
            
            EffectManager.RegisterEffect("Delay", delay);
            StartUpdateLoop();
        }

        private void DisplayControllerStatus()
        {
            if (IsDisposed) return;
            input?.Update();
            output?.Update();

            try
            {
                this.Invoke(new Action(() =>
                {
                    if (input != null && input.Connected)
                    {
                        UpdateJoyDisp(posInL, posInR, input);
                        cbInA.Checked = input.State.Buttons.HasFlag(GamepadButtonFlags.A);
                        cbInB.Checked = input.State.Buttons.HasFlag(GamepadButtonFlags.B);
                        cbInX.Checked = input.State.Buttons.HasFlag(GamepadButtonFlags.X);
                        cbInY.Checked = input.State.Buttons.HasFlag(GamepadButtonFlags.Y);
                    }
                    if (output != null && output.Connected)
                    {
                        UpdateJoyDisp(posOutL, posOutR, output);

                        cbOutA.Checked = output.State.Buttons.HasFlag(GamepadButtonFlags.A);
                        cbOutB.Checked = output.State.Buttons.HasFlag(GamepadButtonFlags.B);
                        cbOutX.Checked = output.State.Buttons.HasFlag(GamepadButtonFlags.X);
                        cbOutY.Checked = output.State.Buttons.HasFlag(GamepadButtonFlags.Y);
                    }
                    posInL.Parent.Refresh();
                    posOutL.Parent.Refresh();
                    posInR.Parent.Refresh();
                    posOutR.Parent.Refresh();
                }));
            }
            catch
            {

            }
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            input = new XInputController((int)nmInputController.Value);
            Console.WriteLine($"Connected[{(int)nmInputController.Value}]: {input?.Connected}");

            if (input.Connected)
            {
                lblInputInd.Text = $"Input Ind: {(int)nmInputController.Value}";

                //bConnect.Enabled = false;
            }
        }

        private async void bCreateVirt_Click(object sender, EventArgs e)
        {
            bCreateVirt.Enabled = false;

            var controller = CtlrManager.CreateVirtualController();
            funOutput = new FunController(controller);
            await Task.Delay(6000);

            //funOutput.UserIndex = funOutput.ctlr.UserIndex;
            //TODO: figure out the user index bug
            output = new XInputController(funOutput.UserIndex);


            Console.WriteLine($"Connected Virtual Controller[{funOutput.UserIndex}]: {output?.Connected}");
            //Console.WriteLine($"Expected: {1}, got {output.UserIndex}");
            lblOutputInd.Text = $"Output Ctlr: {funOutput.UserIndex}";
            bStartDelay.Enabled = true;
            bConnect.Enabled = true;

            //Console.WriteLine("Virtual Connected Controllers DEBUG:");
            //var ctlrs = InputFunNullifier.CtlrManager.GetAllControllers().Select(x => (int)x.UserIndex).ToArray();
            //foreach (var ctlr in ctlrs)
            //{
            //    if (input != null && ctlr == input.UserIndex) continue;
            //    Console.WriteLine($"Available Controllers: {ctlr}");
            //}
        }

        private void nmDelay_ValueChanged(object sender, EventArgs e)
        {
            delay?.ChangeDelay((int)nmDelay.Value);
        }

        private void bPrintCtlrs_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connected Controllers DEBUG:");
            var ctlrs = InputFunNullifier.CtlrManager.GetAllControllers().Select(x => (int)x.UserIndex).ToArray();
            foreach (var ctlr in ctlrs)
            {
                if (input != null && ctlr == input.UserIndex)
                {
                    Console.WriteLine($"Input Controller: {ctlr}");
                }
                if (output != null && ctlr == output.UserIndex)
                {
                    Console.WriteLine($"Output(Virtual) Controller: {ctlr}");
                }

                Console.WriteLine($"Available Controller: {ctlr}");
            }
        }

        bool countCancelled = false;
        private async void bCountUp_Click(object sender, EventArgs e)
        {
            const int max = 2000;
            countCancelled = false;
            bCountUp.Enabled = false;
            bCountDownTo0.Enabled = false;
            while(!countCancelled && delay.Delay < max)
            {
                nmDelay.Value = Math.Min((int)nmDelay.Value + (int)nmCountRate.Value, max);
                await Task.Delay((int)nmCountWait.Value);
            }
            bCountUp.Enabled = true;
            bCountDownTo0.Enabled = true;

        }

        private async void bCountDownTo0_Click(object sender, EventArgs e)
        {
            countCancelled = false;
            bCountUp.Enabled = false;
            bCountDownTo0.Enabled = false;
            while (!countCancelled && delay.Delay > 0)
            {
                nmDelay.Value = Math.Max((int)nmDelay.Value - (int)nmCountRate.Value, 0);
                await Task.Delay((int)nmCountWait.Value);
            }
            bCountUp.Enabled = true;
            bCountDownTo0.Enabled = true;
        }

        private void bCancelDelayTick_Click(object sender, EventArgs e)
        {
            countCancelled = true;
        }


        volatile bool updating = false;
        private void StartUpdateLoop()
        {
            mainLoop = new System.Timers.Timer(15);
            mainLoop.Elapsed += MainLoop_Elapsed;
            mainLoop.Enabled = true;
            mainLoop.Start();
            updating = false;
        }

        private void StopUpdateLoop()
        {
            if (inputGrabTimer != null)
            {
                mainLoop.Stop();
                mainLoop.Enabled = false;
                mainLoop.Elapsed -= MainLoop_Elapsed;
                mainLoop.Dispose();
                mainLoop = null;
            }
            updating = false;
        }


        System.Timers.Timer inputGrabTimer = null;
        private void bInputDebug_Click(object sender, EventArgs e)
        {
            //bInputDebug.Enabled = false;
            //inputGrabTimer = new System.Timers.Timer(15);
            //inputGrabTimer.Elapsed += InputGrabTimer_Elapsed;
            //inputGrabTimer.Enabled = true;
            //inputGrabTimer.Start();
            //updating = false;
        }

        private void StopInputDebug()
        {
            //if (inputGrabTimer != null)
            //{
            //    inputGrabTimer.Stop();
            //    inputGrabTimer.Enabled = false;
            //    inputGrabTimer.Elapsed -= MainLoop_Elapsed;
            //    inputGrabTimer.Dispose();
            //    inputGrabTimer = null;
            //}
            updating = false;
        }

        private void MainLoop_Elapsed(object sender, ElapsedEventArgs e)
        {
            //RecieveData
            if (!updating)
            {
                updating = true;
                //Delay_InputUpdated();
                //todo: better delta time
                InputFunNullifier.Core.Update(15);
                updating = false;
            }
        }

        private void bChangeOutput_Click(object sender, EventArgs e)
        {
            output = new XInputController((int)nmOutCtlr.Value);
        }

        private void bChangeInput_Click(object sender, EventArgs e)
        {
            input = new XInputController((int)nmInputController.Value);
        }
    }
}
