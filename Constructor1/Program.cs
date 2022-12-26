using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("this is default constructor");
            Console.WriteLine("---------------------------");
        }
        public Program(string name, int Roll, string Address)
        {
            Console.WriteLine("This is parameterized constructor");
            Console.WriteLine(name+"\n"+ Roll+"\n"+ Address);
            
           
        }
        static Program()
        {
            Console.WriteLine("This is static constructor");
            Console.WriteLine("---------------------------");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program("Ashis", 20, "Suryabinayak");
            Console.ReadKey();
        }
    }
}
//Static constructor will run only one time