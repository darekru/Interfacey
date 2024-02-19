using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacey
{
    public class someClass2 : ISomeInterface
    {
        public void someMessage()
        {
            Console.WriteLine("it is message from someClass2");
        }

    }
}
