using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligEn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int cites = Convert.ToInt32(numberOfCities.Text);
            int[,] array1 = generateGraph(cites);
            randomResult.Text = calculateTotalCost((randMethod(array1, cites)), array1).ToString();
            itRandomResult.Text = calculateTotalCost((iterativeRndMethod(array1, cites)), array1).ToString();
            
        }
        static int[,] generateGraph(int cities)// Metode for å generere matrise 
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
        static string printGraph(int[,] array, int size)// Bare for å se at det blir generert riktig matrise
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
        static int[] randMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();
            return visited;
        }
        static int[] iterativeRndMethod(int[,] array, int cities)
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
        static int calculateTotalCost(int[] visted, int[,] array)
        {
            int totalCost = 0;
            for (int i = 0; i < (visted.GetLength(0)-1); i++)
                totalCost += array[visted[i], visted[i + 1]];
            totalCost += array[visted[(visted.GetLength(0) - 1)], visted[0]];
            return totalCost;

        }
    }
}
