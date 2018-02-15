using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class Dal
    {
        public string TxtFile()
        {
            StreamReader sr = File.OpenText("C:\\Users\\Ulrik\\Desktop\\Test.txt");
            {
                String line = sr.ReadToEnd();
                return line;

            }
        }
    }
}
