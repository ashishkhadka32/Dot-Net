using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("ram sam");
            list.Add("gita sita");

            foreach(string item in list)
            {
                Console.WriteLine(item);
              
            }
            Console.ReadKey();
        }
    }
}
