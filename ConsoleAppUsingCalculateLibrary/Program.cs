using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;

namespace ConsoleAppUsingCalculateLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cl = new Calculation();
            cl.No1 = 404;
            cl.No2 = 50;
            Console.WriteLine(cl.Add());
            Console.WriteLine(cl.Difference());
            Console.WriteLine(cl.Multiply());
            Console.WriteLine(cl.Division());

        }
    }
}
