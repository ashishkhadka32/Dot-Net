using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("************************");
            Console.WriteLine("{0}+{1}={2}\n{3}-{4}={5}", a, b, a + b, a, b, a - b);
            Console.WriteLine("{0}*{1}={2}\n{3}/{4}={5}", a, b, a * b, a, b, a / b);
        }
    }
}
