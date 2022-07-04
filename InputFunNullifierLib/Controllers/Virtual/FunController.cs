using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using SharpDX.XInput;

namespace InputFunNullifier.Controllers
{
    public class FunController
    {
        public IXbox360Controller ctlr { get; private set; }

        public int UserIndex => ctlr.UserIndex;

        public FunController(IXbox360Controller ctlr)
        {
            this.ctlr = ctlr;
        }

        public void SetState(Gamepad state)
        {
            try
            {
                short AxisValue(BindingAxis axis)
                {
                    switch (axis)
                    {
                        case BindingAxis.RightX:
                            return state.RightThumbX;
                        case BindingAxis.RightY:
                            return state.RightThumbY;
                        case BindingAxis.LeftX:
                            return state.LeftThumbX;
                        case BindingAxis.LeftY:
                            return state.LeftThumbY;
                        default:
                            return 0;
                    }
                }
                byte TriggerValue(BindingTrigger trigger)
                {
                    switch (trigger)
                    {
                        case BindingTrigger.Left:
                            return state.LeftTrigger;
                        case BindingTrigger.Right:
                            return state.RightTrigger;
                        default:
                            return 0;
                    }
                }
                void UpdateButton(Xbox360Button button) { ctlr.SetButtonState(button, state.Buttons.HasFlag(CtlrManager.CurBindings[button])); }
                void UpdateAxis(Xbox360Axis axis) { ctlr.SetAxisValue(axis, AxisValue(CtlrManager.CurBindings[axis])); }
                void UpdateTrigger(Xbox360Slider slider) { ctlr.SetSliderValue(slider, TriggerValue(CtlrManager.CurBindings[slider])); }

                UpdateButton(Xbox360Button.X);
                UpdateButton(Xbox360Button.Y);
                UpdateButton(Xbox360Button.A);
                UpdateButton(Xbox360Button.B);
                UpdateButton(Xbox360Button.Up);
                UpdateButton(Xbox360Button.Down);
                UpdateButton(Xbox360Button.Left);
                UpdateButton(Xbox360Button.Right);
                UpdateButton(Xbox360Button.LeftShoulder);
                UpdateButton(Xbox360Button.LeftThumb);
                UpdateButton(Xbox360Button.RightShoulder);
                UpdateButton(Xbox360Button.RightThumb);
                UpdateButton(Xbox360Button.Start);
                UpdateButton(Xbox360Button.Back);

                UpdateAxis(Xbox360Axis.LeftThumbX);
                UpdateAxis(Xbox360Axis.LeftThumbY);
                UpdateAxis(Xbox360Axis.RightThumbX);
                UpdateAxis(Xbox360Axis.RightThumbY);

                UpdateTrigger(Xbox360Slider.LeftTrigger);
                UpdateTrigger(Xbox360Slider.RightTrigger);
            }
            catch (Nefarius.ViGEm.Client.Exceptions.VigemBusNotFoundException b)
            {
                //Different thread closed bus probably
                Console.WriteLine("Bus closed, unable to do the thing");
            }
        }

        public virtual void SubmitReport()
        {
            try
            {
                ctlr.SubmitReport();
            }
            catch (Nefarius.ViGEm.Client.Exceptions.VigemBusNotFoundException b)
            {
                //Different thread closed bus probably
                Console.WriteLine("Bus closed, unable to do the thing");
            }
        }
    }
}
