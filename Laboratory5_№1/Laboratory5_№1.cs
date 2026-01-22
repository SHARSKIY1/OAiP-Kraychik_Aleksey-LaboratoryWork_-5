using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5__1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Я программа которая показывает лежит ли число введённое вами ");
            Equation equation  = new Equation();
            equation.Read();
            equation.Function();
            equation.Display();
        }
    }
}
