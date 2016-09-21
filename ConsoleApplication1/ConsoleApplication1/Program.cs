using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] array = new int[10, 10];
            for (int i = 0;  i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int random = rnd.Next(0, 10);
                    array[i, j] = random;
                    array[j, i] = random;
                }
            }

            for (int i =0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    System.Console.Write("{0, -2}", array[i,j]);
                }
                System.Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
