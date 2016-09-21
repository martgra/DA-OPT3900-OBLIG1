using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Ran_Method
    {
        public static int[,] generateArray(int size)
        {


            Random rnd = new Random();
            int[,] array = new int[size, size];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int random = rnd.Next(0, 20);
                    array[i, j] = random;
                    array[j, i] = random;
                }
            }

            return array;

        }
    }
}
