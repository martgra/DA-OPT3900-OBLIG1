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
        // metode for å regne ut korteste rute gjennom en greedy itterativ måte. Initieres ved å gi array som inneholder rute, samt graf som beskriver distanser mellom byene
        {

            int[] routeCopy = new int[route.GetLength(0)];
            // oppretter tabell som ruten skal kopieres over i. Opprettet pga problemer med referanse til objektet
            int itteration = 10000;
            //antall ganger metoden skal forsøke å finne bedre rute.
            int length = route.GetLength(0);
            // får lengde på ruten
            Array.Copy(route, routeCopy, length);
            //kopierer ruten til kopitabellen routeCopy
            int bestResult = CalculateCost.calculateTotalCost(routeCopy, cities);
            //oppretter og initerer "best result" variabel. skal brukes for å avgjøre om en rute skal forkastes eller beholdes
            int currentRoute = CalculateCost.calculateTotalCost(routeCopy, cities);
            // oppretter og initerer variabel som inneholder verdi på nåværende rute
            Random rnd = new Random();
            // oppretter objekt av typen Random.

            for (int i = 0; i < itteration; i ++)
            // for-løkke som kjører gitt antall ganger. ingen direkte stoppkriterium
            {
                int cityOne = rnd.Next(0, length);
                // oppretter lokal variabel for tilfeldig posisjon 1 i ruten. Gis tilfelldig verdi i intervall antall byer.
                int cityTwo = rnd.Next(0, length);
                // oppretter lokal variabel for tilfeldig posisjon 2 i ruten. Gis tilfelldig verdi i intervall antall byer.

                if (cityOne != cityTwo)
                //sjekker at by nr 1 ikke er lagret i samme posisjon som by nr 2.
                {
                    int temp1 = routeCopy[cityOne];
                    // mellomlagerer hvilken by som befinner seg i den første posisjonen i ruten. 
                    int temp2 = routeCopy[cityTwo];
                    // mellomlagrer hvilken by som befinner seg på den andre posisjonen i ruten.

                    routeCopy[cityOne] = temp2;
                    // legger byen som ligger lagret i posisjon 2 i posisjon 1.
                    routeCopy[cityTwo] = temp1;
                    // legger by som ligger lagret i posisjon 1 i posisjon 2. 

                    currentRoute = CalculateCost.calculateTotalCost(routeCopy, cities);
                    // kalkulerer verdien på ruten etter bytte av rekkefølge.

                    if(currentRoute < bestResult)
                    {
                        bestResult = currentRoute;
                    }
                    // hvis det nåværende resultatet er bedre enn beste resultat så oppdateres beste resultat til nåværende resultat og ruten beholdes.

                    else
                    {
                        routeCopy[cityOne] = temp1;
                        routeCopy[cityTwo] = temp2;
                    }
                    // hvis nåværende rute ikke er bedre enn beste rute revereseres endringen.                     

                }


            }
            
            return routeCopy;
            // returnerer den forbedrede ruten.
        }        
    }
}
