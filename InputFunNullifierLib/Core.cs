using InputFunNullifier.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFunNullifier
{
    public static class Core
    {
        public static event Action InputUpdated;

        public static void Update(int deltaMS)
        {
            CtlrManager.InputController?.Update();
            EffectManager.Update(deltaMS);
            CtlrManager.OutputController?.SubmitReport();
            InputUpdated?.Invoke();
        }

    }
}
