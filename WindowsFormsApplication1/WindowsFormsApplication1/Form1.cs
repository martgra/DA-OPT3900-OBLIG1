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
            greedy.Text = greedyMethod(array1, size).ToString();
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

            totalCost += array[visited[cities - 1], visited[0]];//tilbake til første by

            return totalCost;
        }
        static int iterativeRandomMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int tries = 100;
            
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
        static int greedyMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int totalCost = 0;
            int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();//lager en random sortert array med byer
            
            return totalCost;
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void greedy_Click(object sender, EventArgs e)
        {

        }

    }
}
