using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();

            Console.WriteLine(service.TxtFile());
            Console.ReadLine();
        }
    }
}
