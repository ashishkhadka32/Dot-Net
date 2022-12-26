using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Result = new int[2, 2];
            int[,] Matrix1 = { { 4, 5 }, { 5, 6 } };
            int[,] Matrix2 = { { 10, 9 }, { 8, 9 } };
            Console.WriteLine("\nSum of Both Matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Result[i, j] = Matrix1[i, j] + Matrix2[i, j];
                    Console.Write($"{Result[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
