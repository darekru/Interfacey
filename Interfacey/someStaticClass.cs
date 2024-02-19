using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacey
{
    static class someStaticClass
    {
        public static void someMessage(ISomeInterface par)
        {
            par.someMessage();
        }
    }
}
