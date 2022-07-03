using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputFunNullifier.Controllers;
using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using SharpDX.XInput;

namespace InputFunNullifier
{
    public static class CtlrManager
    {
        static List<IXbox360Controller> virtualControllers = new List<IXbox360Controller>();
        static ViGEmClient client = new ViGEmClient();

        public static XInputController InputController { get; set; } = null;
        public static FunController OutputController { get; set; } = null;


        internal static Bindings CurBindings;
        static CtlrManager()
        {
            CurBindings = Bindings.Default;
        }

        public static void ResetBindings()
        {
            CurBindings = Bindings.Default;
        }

        public static IXbox360Controller CreateVirtualController()
        {
            client.Dispose();
            client = new ViGEmClient();
            IXbox360Controller controller = client.CreateXbox360Controller();
            virtualControllers.Add(controller);
            controller.Connect();
            return controller;
        }

        //public static X360Controller CreateVirtualController()
        //{
        //    //client.CreateXbox360Controller().Disconnect();
        //    X360Controller controller = new X360Controller();
        //    //controller.
        //    virtualControllers2.Add(controller);
        //    //controller.Connect();
        //    return controller;
        //}

        public static void ShutDown()
        {
            foreach (var c in virtualControllers)
            {
                //try
                //{
                c.Disconnect();
                //}//catch (Nefarius.ViGEm.Client.Exceptions.conn)
            }

            client.Dispose();
        }

        public static Controller GetControllerForMonitoring(UserIndex index)
        {
            return new Controller(index);
        }

        public static bool IsVirtualController(int index)
        {
            if (index < 0 || index > 3) return false;
            return virtualControllers.Any(x => x.UserIndex == index);
        }

        public static bool IsVirtualController(UserIndex index)
        {
            if (index == UserIndex.Any) return false;
            return virtualControllers.Any(x => x.UserIndex == (int)index);
        }

        public static List<Controller> GetAllControllers()
        {
            List<Controller> connectedControllers = new List<Controller>();
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

            foreach (var c in controllers)
            {
                if (c.IsConnected)
                {
                    connectedControllers.Add(c);
                }
            }

            return connectedControllers;
        }

        public static List<Controller> GetActiveControllers()
        {
            List<Controller> connectedControllers = new List<Controller>();
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

            foreach (var c in controllers)
            {
                if (c.IsConnected && !IsVirtualController((int)c.UserIndex))
                {
                    connectedControllers.Add(c);
                }
            }

            return connectedControllers;
        }

    }
}
