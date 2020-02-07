using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaku.Utility
{
    class DataLoader
    {
        public static string Loader(string fileName)
        {
            string Content = "Quote the raven: NEVERMORE";

            if(File.Exists(fileName))
            {
                Content = File.ReadAllText(fileName);
            }

            return Content;
        }
    }
}
