using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;

namespace InputFunNullifier.Controllers
{
    public class XInputController
    {
        Controller controller;
        public Gamepad State { get; private set; }
        public bool Connected => controller.IsConnected;
        public int deadband = 2500;
        public Point leftThumb, rightThumb = new Point(0, 0);
        public float leftTrigger, rightTrigger;
        public int UserIndex => (int)controller.UserIndex;
        public XInputController(int userIndex)
        {
            controller = new Controller((UserIndex)userIndex);
        }

        public XInputController(UserIndex userIndex)
        {
            controller = new Controller(userIndex);
        }

        // Call this method to update all class values
        public void Update()
        {
            if (!Connected)
                return;

            State = controller.GetState().Gamepad;

            leftThumb.x = ((Math.Abs((float)State.LeftThumbX) < deadband) ? 0 : (float)State.LeftThumbX / short.MaxValue * 100)/100f;
            leftThumb.y = -1.0f * ((Math.Abs((float)State.LeftThumbY) < deadband) ? 0 : (float)State.LeftThumbY / short.MaxValue * 100)/100f;
            rightThumb.x = ((Math.Abs((float)State.RightThumbX) < deadband) ? 0 : (float)State.RightThumbX / short.MaxValue * 100) / 100f;
            rightThumb.y = -1.0f * ((Math.Abs((float)State.RightThumbY) < deadband) ? 0 : (float)State.RightThumbY / short.MaxValue * 100) / 100f;

            leftTrigger = State.LeftTrigger;
            rightTrigger = State.RightTrigger;
        }
    }
}
