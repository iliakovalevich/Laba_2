using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class IOF
    {
        public string Read(string path)
        {
            string readText = File.ReadAllText(path);
            return readText;
        }


    }
}
