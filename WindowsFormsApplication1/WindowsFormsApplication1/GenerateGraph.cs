using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class GenerateGraph
    {
        public static int[,] generateGraph(int cities)// Metode for å generere matrise 
        {
            Random rnd = new Random();
            int[,] graph = new int[cities, cities];
            // Random distance between cities
            for (int i = 0; i < cities; i++)
                for (int j = 0; j < (i + 1); j++)
                {
                    if (i == j)
                        graph[i, j] = 0;
                    else
                        graph[j, i] = graph[i, j] = rnd.Next(1, 10);
                }
            return graph;
        }
        public static string printGraph(int[,] array, int size)// Bare for å se at det blir generert riktig matrise
        {
            string text = "";
            for (int a = 0; a < size; a++)
            {
                for (int b = 0; b < size; b++)
                    text += array[a, b] + " ";
                text += "\n";
            }
            return text;
        }
    }
}
