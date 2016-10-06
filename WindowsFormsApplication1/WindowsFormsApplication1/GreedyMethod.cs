using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class GreedyMethod
    {
        public static int greedyMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int totalCost = 0;
            int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();//lager en random sortert array med byer

            return totalCost;
        }

        public static int [] greedyRoute(int[,] cities)
        {
            int[] route = new int[cities.GetLength(0)];
            bool[] connected = new bool[cities.GetLength(0)];
            int i, j;
            Random rnd = new Random();


            for (i = 0; i < cities.GetLength(0); i++)
            {
                route[i] = i;
                connected[i] = false;
            }

            i = route[rnd.Next(0, cities.GetLength(0))];
            route[0] = i;
            route[i] = 0;


            //connected[0] = true;
            int current = route[0];
            int min;
            int next = 1;

            int cost = 0;

            for (i = 0; i < cities.GetLength(0) - 1; i++)
            {
                min = -1;

                for (j = 0; j < cities.GetLength(0); j++)
                {
                    if (cities[current, j] != 0 && connected[j] == false)
                    {
                        if (min == -1)
                        {
                            min = cities[current, j];
                            next = j;
                        }

                        else if (cities[current, j] < min)
                        {
                            min = cities[current, j];
                            next = j;
                        }
                    }
                }

                if (next != route[i + 1])
                {
                    route[cities.GetLength(0) - 1] = i;
                    route[i + 1] = next;
                }

                connected[current] = true;
                current = next;
            }

        return route;

        }
    }
}
