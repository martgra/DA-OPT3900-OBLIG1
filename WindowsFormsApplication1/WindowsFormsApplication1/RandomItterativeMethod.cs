using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class RandomItterativeMethod
    {
        public static int[] iterativeRndMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int tries = 5;
            int bestValue = Int16.MaxValue;
            int[] bestRoute = new int[cities];
            while (tries > 0)
            {
                int mincost = 0;
                int totalCost = 0;
                int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();
                for (int i = 0; i < (cities - 1); i++)
                    totalCost += array[visited[i], visited[i + 1]];
                totalCost += array[visited[cities - 1], visited[0]];
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
