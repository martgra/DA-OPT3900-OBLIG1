using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligEn
{
    class GreedyItterative
    {
        public static int [] greedyItterative(int [] route, int[,] cities )
        {
            bool breakCondition = false;
            //skal bli true hvis break conditions oppnås
            Random rnd = new Random();
            //oppretter random metode
            int bestRouteCost = CalculateCost.calculateTotalCost(route, cities);
            int currentRouteCost;
            int tempOne = 0;
            int tempTwo = 0;
            int cityOne;
            int cityTwo;
            int counter = 0;

            while (breakCondition != true)
            {
                cityOne = rnd.Next(0, route.GetLength(0));
                cityTwo = rnd.Next(0, route.GetLength(0));
                
                if (cityOne != cityTwo)
                {
                    tempOne = route[cityOne];
                    tempTwo = route[cityTwo];
                    route[cityOne] = tempTwo;
                    route[cityTwo] = tempOne;
                }
                currentRouteCost = CalculateCost.calculateTotalCost(route, cities);
                if (currentRouteCost < bestRouteCost)
                {
                    counter = 0;
                    bestRouteCost = currentRouteCost;
                }
                else
                {
                    route[cityOne] = tempOne;
                    route[cityTwo] = tempTwo;
                    counter++;
                }

                if (counter > 1000 )
                {
                    breakCondition = true;
                }

            }
            //skal kjøre Greedy itterative frem til break condtions oppnås

            return route;
        }        
    }
}
