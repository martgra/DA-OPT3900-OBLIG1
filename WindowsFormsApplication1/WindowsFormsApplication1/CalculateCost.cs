using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CalculateCost
    {
        public static int calculateTotalCost(int[] visted, int[,] array)
        {
            int totalCost = 0;
            for (int i = 0; i < (visted.GetLength(0) - 1); i++)
                totalCost += array[visted[i], visted[i + 1]];
            totalCost += array[visted[(visted.GetLength(0) - 1)], visted[0]];
            return totalCost;

        }
    }
}
