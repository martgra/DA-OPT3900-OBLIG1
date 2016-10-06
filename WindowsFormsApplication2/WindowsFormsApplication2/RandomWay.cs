using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class RandomWay
    {
        

        public static int randomTour(int[,] array)
        {
            Random rnd = new Random();
            int cities = 20;
            int start_city1 = rnd.Next(0, cities);
            int start_city = start_city1;
            array[start_city, start_city] = - 1;
            int next_city;
            int cost = 0;
            Boolean visited = true;

            for( int i = 0; i < cities; i++)
            {
                while (visited == true)
                {
                    next_city = rnd.Next(0, cities);
                    if (array[next_city,0] != -1)
                    {
                        cost = cost + array[start_city, next_city];
                        for (int j = 0; j < cities; j++)
                        {
                            array[next_city, j] = -1;
                        }
                        start_city = next_city;
                        visited = false;
                    }
                }
            }



            return cost;
        }


    }
}
