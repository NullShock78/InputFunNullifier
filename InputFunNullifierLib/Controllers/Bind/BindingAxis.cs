using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFunNullifier.Controllers
{
    [Flags]
    public enum BindingAxis
    {
        None = 0,
        RightX = 1,
        RightY = 2,
        LeftX = 4,
        LeftY = 8
    }
}
