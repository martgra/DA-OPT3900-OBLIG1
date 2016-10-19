using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligEn
{
    public class RandomItterativeMethod
    {
        public static int[] iterativeRndMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int tries = 10000;
            int bestValue = Int32.MaxValue;
            int[] bestRoute = new int[cities];
            while (tries > 0)
            {
                int mincost = 0;
                int totalCost = 0;
                int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();
              /*for (int i = 0; i < (cities - 1); i++)
                    totalCost += array[visited[i], visited[i + 1]];
                totalCost += array[visited[cities - 1], visited[0]]; */
                totalCost = CalculateCost.calculateTotalCost(visited, array);
                mincost = totalCost;

                if (bestValue > mincost)
                {
                    Array.Copy(visited, bestRoute, cities);
                    bestValue = mincost;
                }
                tries--;
            }
            return bestRoute;
        }
    }
}
