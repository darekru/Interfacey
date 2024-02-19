using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacey
{
    public class someClass1 : ISomeInterface
    {
        public void someMessage()
        {
            Console.WriteLine("it is message from someClass1");
        }

    }
}
