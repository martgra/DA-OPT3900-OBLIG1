using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligEn
{
    class CalculateCost
    {
        public static int calculateTotalCost(int[] visted, int[,] array)
        // metoden initialiseres med et array som innholder rekkefølgen på besøkte byer (visited) og grafen som beskriver avstanden mellom byene (array)
        {
            int totalCost = 0;
            // variabel for å samle total kostnad

            for (int i = 0; i < (visted.GetLength(0)-1); i++)
            // for løkke som går lik lengden på dimensjnen i array "visited"
            {
                totalCost += array[visted[i], visted[i + 1]];
                //legger kostnaden fra nåværende by til neste by til total kostnad
            }
                
            totalCost += array[visted[(visted.GetLength(0) - 1)], visted[0]];
            //legger til kostnaden fra siste besøkte by tilbake til start

            return totalCost;
            // returnerer den totale kostanden for ruten.

        }
    }
}
