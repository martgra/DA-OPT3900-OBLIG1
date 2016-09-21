using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int size = Convert.ToInt16(numbTries.Text);
            int[,] array1 = generateGraph(size);
           // array.Text = printGraph(array1, size);
            totalCost.Text = randomMethod(array1, size).ToString();
            minCost.Text = iterativeRandomMethod(array1, size).ToString();
            greedy.Text = greedyRoute(array1).ToString();
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
        static int randomMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int totalCost = 0;
            int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();//lager en random sortert array med byer
            for (int i = 0; i < (cities - 1); i++)
                totalCost += array[visited[i], visited[i + 1]];

            totalCost += array[visited[cities - 1], visited[0]];//tilbake til første by ...

            return totalCost;
        }
        static int iterativeRandomMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int tries = 5;
            
            int bestCost = Int16.MaxValue;
            while (tries > 0)
            {
                int minCost = 0;
                int totalCost = 0;
                int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();//lager en random sortert array med byer
                for (int i = 0; i < (cities - 1); i++)
                    totalCost += array[visited[i], visited[i + 1]];
                totalCost += array[visited[cities - 1], visited[0]];//tilbake til første by
                minCost = totalCost;
                if (bestCost > minCost)
                    bestCost = minCost;             
                tries -= 1;
            }

            return bestCost;
        }
        private void label2_Click(object sender, EventArgs e)
        {


        }
        static int improvedRandomMethod(int[,] array, int cities)
        {
            return 1;
        }
        static int improvedIterativeRadnomMethod(int[,] array, int cities)
        {
            return 1;
        }

        private void greedy_Click(object sender, EventArgs e)
        {

        }
        static int greedyRoute(int[,] cities)
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

            for (i = 0; i < cities.GetLength(0) - 1; i++)
            {
                cost += cities[route[i], route[i + 1]];
            }

            cost += cities[route[cities.GetLength(0) - 1], route[0]];

  
            return cost;

        }

    }
}
