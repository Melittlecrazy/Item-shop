using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaku.Utility
{
    class Interface
    {
        public static void Pause()
        {
            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }
}
