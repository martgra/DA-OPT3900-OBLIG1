using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligEn
{
    public class GenerateGraph
    // klasse som inneholder metoder for å generere og skrive ut graf.
    {
        public static int[,] generateGraph(int cities)// Metode for å generere matrise 
        // metode for å generere graf. Initieres med integer som angir antall byer
        {
            Random rnd = new Random();
            // oppretter variabel av typen random
            int[,] graph = new int[cities, cities];
            // Graf for Random distance between cities

            for (int i = 0; i < cities; i++)
                for (int j = 0; j < (i + 1); j++)
                {
                    if (i == j)
                        graph[i, j] = 0;
                    else
                        graph[j, i] = graph[i, j] = rnd.Next(1, 10);
                        // definerer hvilke verdier som skal fylles inn på gitt posisjon
                }
            return graph;
            // returnerer graf som fyller inn tifeldige verider
        }


        public static string printGraph(int[,] array, int size)// Bare for å se at det blir generert riktig matrise
        // funksjon for å skrive ut graf
        {
            string text = "";
            for (int a = 0; a < size; a++)
            {
                for (int b = 0; b < size; b++)
                    text += array[a, b] + " ";
                text += "\n";
            }
            return text;
            // returnerer en string med grafen
        }
    }
}
