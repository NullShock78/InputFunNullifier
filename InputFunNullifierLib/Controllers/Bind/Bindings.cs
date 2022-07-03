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
    public class Bindings
    {
        //TODO: encapsulate better or something idk
        public static Bindings Default { get; private set; }

        static Bindings()
        {
            Default = new Bindings(false);
            Default.ButtonBindings[Xbox360Button.A] = GamepadButtonFlags.A;
            Default.ButtonBindings[Xbox360Button.B] = GamepadButtonFlags.B;
            Default.ButtonBindings[Xbox360Button.X] = GamepadButtonFlags.X;
            Default.ButtonBindings[Xbox360Button.Y] = GamepadButtonFlags.Y;
            Default.ButtonBindings[Xbox360Button.Down] = GamepadButtonFlags.DPadDown;
            Default.ButtonBindings[Xbox360Button.Left] = GamepadButtonFlags.DPadLeft;
            Default.ButtonBindings[Xbox360Button.Right] = GamepadButtonFlags.DPadRight;
            Default.ButtonBindings[Xbox360Button.Up] = GamepadButtonFlags.DPadUp;
            Default.ButtonBindings[Xbox360Button.RightShoulder] = GamepadButtonFlags.RightShoulder;
            Default.ButtonBindings[Xbox360Button.RightThumb] = GamepadButtonFlags.RightThumb;
            Default.ButtonBindings[Xbox360Button.LeftShoulder] = GamepadButtonFlags.LeftShoulder;
            Default.ButtonBindings[Xbox360Button.LeftThumb] = GamepadButtonFlags.LeftThumb;
            Default.ButtonBindings[Xbox360Button.Start] = GamepadButtonFlags.Start;
            Default.ButtonBindings[Xbox360Button.Back] = GamepadButtonFlags.Back;
            //Default.ButtonBindings[Xbox360Button.Guide] = GamepadButtonFlags.;

            Default.AxisBindings[Xbox360Axis.RightThumbX] = BindingAxis.RightX;
            Default.AxisBindings[Xbox360Axis.RightThumbY] = BindingAxis.RightY;
            Default.AxisBindings[Xbox360Axis.LeftThumbX] = BindingAxis.LeftX;
            Default.AxisBindings[Xbox360Axis.LeftThumbY] = BindingAxis.LeftY;

            Default.TriggerBindings[Xbox360Slider.LeftTrigger] = BindingTrigger.Left;
            Default.TriggerBindings[Xbox360Slider.RightTrigger] = BindingTrigger.Right;
        }

        public Dictionary<Xbox360Button, GamepadButtonFlags> ButtonBindings { get; private set; } = new Dictionary<Xbox360Button, GamepadButtonFlags>();
        public Dictionary<Xbox360Axis, BindingAxis> AxisBindings { get; private set; } = new Dictionary<Xbox360Axis, BindingAxis>();
        public Dictionary<Xbox360Slider, BindingTrigger> TriggerBindings { get; private set; } = new Dictionary<Xbox360Slider, BindingTrigger>();



        public Bindings(bool useDefault = true)
        {
            if (useDefault)
            {
                foreach (var b in Default.ButtonBindings)
                {
                    ButtonBindings[b.Key] = b.Value;
                }
                foreach (var a in Default.AxisBindings)
                {
                    AxisBindings[a.Key] = a.Value;
                }
                foreach (var t in Default.TriggerBindings)
                {
                    TriggerBindings[t.Key] = t.Value;
                }
            }
        }


        public GamepadButtonFlags this[Xbox360Button b]
        {
            get
            {
                if (b == Xbox360Button.Guide) return GamepadButtonFlags.None;

                if (ButtonBindings.TryGetValue(b, out GamepadButtonFlags flag))
                {
                    return flag;
                }
                else
                {
                    return Default.ButtonBindings[b];
                }
            }
            set
            {
                ButtonBindings[b] = value;
            }
        }

        public BindingAxis this[Xbox360Axis axis]
        {
            get
            {

                if (AxisBindings.TryGetValue(axis, out BindingAxis axisOut))
                {
                    return axisOut;
                }
                else
                {
                    return Default.AxisBindings[axis];
                }
            }
            set
            {
                AxisBindings[axis] = value;
            }
        }

        public BindingTrigger this[Xbox360Slider trigger]
        {
            get
            {

                if (TriggerBindings.TryGetValue(trigger, out BindingTrigger triggerOut))
                {
                    return triggerOut;
                }
                else
                {
                    return Default.TriggerBindings[trigger];
                }
            }
            set
            {
                TriggerBindings[trigger] = value;
            }
        }


    }
}
