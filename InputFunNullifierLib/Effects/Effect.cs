using InputFunNullifier.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFunNullifier.Effects
{
    [Serializable]
    public abstract class Effect
    {
        public bool Enabled { get; set; } = true;
        //protected int output;
        public abstract bool Updatable { get; }


        public Effect(/*FunController output*/)
        {
            //this.output = output;
        }
        public virtual void Initialize() { }

        public virtual void Activate() { }
        public virtual void Deactivate() { }
        public virtual void Trigger() { }
        /// <summary>
        /// Update function, will only be called if Updatable is true
        /// </summary>
        /// <param name="dtMs">delta time in ms</param>
        public virtual void Update(int dtMs) { }

    }
}
