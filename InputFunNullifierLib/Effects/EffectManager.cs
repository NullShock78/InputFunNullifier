using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFunNullifier.Effects
{
    public static class EffectManager
    {
        private static Dictionary<string, Effect> Effects = new Dictionary<string, Effect>();
        private static List<Effect> UpdatableEffects = new List<Effect>();

        public static void Clear()
        {
            Effects.Clear();
            UpdatableEffects.Clear();
        }

        /// <summary>
        /// Register an Effect
        /// </summary>
        /// <param name="id">Effect ID</param>
        /// <param name="effect">Effect instance</param>
        /// <returns>true if the effect was added successfully</returns>
        public static bool RegisterEffect(string id, Effect effect)
        {
            if (!Effects.ContainsKey(id))
            {
                Effects[id] = effect;
                if (effect.Updatable) UpdatableEffects.Add(effect);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static T GetEffect<T>(string id) where T : Effect
        {
            try
            {
                return (T)Effects[id];
            }
            catch
            {
                return null;
            }
        }

        public static void ActivateEffect(string id)
        {
            Effects[id].Activate();
        }

        public static void DectivateEffect(string id)
        {
            Effects[id].Deactivate();
        }

        public static void Update(int deltaMS)
        {
            foreach (var updatable in UpdatableEffects)
            {
                if (updatable.Enabled) updatable.Update(deltaMS);
            }
        }

    }
}
