using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligEn
{
    class GreedyItterative
    {
        internal static object Text;

        public static int [] greedyItterative(int [] route, int[,] cities )
        {

            int[] routeCopy = new int[route.GetLength(0)];
            int length = route.GetLength(0);
            Array.Copy(route, routeCopy, length);

            int bestResult = CalculateCost.calculateTotalCost(routeCopy, cities);
            int currentRoute = CalculateCost.calculateTotalCost(routeCopy, cities);
            

            Random rnd = new Random();

            for (int i = 0; i < 1000000; i ++)
            {
                int cityOne = rnd.Next(0, length);
                int cityTwo = rnd.Next(0, length);

                if(cityOne != cityTwo)
                {
                    int temp1 = routeCopy[cityOne];
                    int temp2 = routeCopy[cityTwo];

                    routeCopy[cityOne] = temp2;
                    routeCopy[cityTwo] = temp1;

                    currentRoute = CalculateCost.calculateTotalCost(routeCopy, cities);

                    if(currentRoute < bestResult)
                    {
                        bestResult = currentRoute;
                    }

                    else
                    {
                        routeCopy[cityOne] = temp1;
                        routeCopy[cityTwo] = temp2;
                    }
                    

                }


            }
            
            return routeCopy;
        }        
    }
}
