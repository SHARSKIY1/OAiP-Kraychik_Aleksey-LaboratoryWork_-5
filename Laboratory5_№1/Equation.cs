using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5__1
{
    class Equation
    {
        public double first {  get; set; }
        public double second { get; set; }
        public double answer { get; set; }

        public void Read()
        {
            Console.WriteLine("Введите первое число A: ");
            string usernumber1 = Console.ReadLine();
            first = double.Parse(usernumber1);
            Console.WriteLine("Введите второе число B: ");
            string usernumber2 = Console.ReadLine();
            second = double.Parse(usernumber2);
        }

        public void Display()
        {
            Console.WriteLine($"Корень выражения: {answer}");
        }

        public void Function()
        {
            double x = 1;
            answer = Math.Sqrt(first * x + second); 
        }
    }
}
