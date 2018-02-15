using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class Dal
    {
        [WebMethod]
        public string TxtFile()
        {
            StreamReader sr = File.OpenText("C:\\Users\\Ulrik\\Desktop\\Test.txt");
            {
                String line = sr.ReadToEnd();
                return line;

                MathService service = new MathService();

                Console.WriteLine(service.TxtFile());
                Console.ReadLine();
            }
}
