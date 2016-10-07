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

        public void buttonCalculate_Click(object sender, EventArgs e)
        {

            if(numberOfCities.Text != "")
            {
                int cities = Convert.ToInt32(numberOfCities.Text);
                int[,] array1 = GenerateGraph.generateGraph(cities);

                int[] randomRoute = RandomMethod.randMethod(array1, cities);
                int[] randomIntterativeRoute = RandomItterativeMethod.iterativeRndMethod(array1, cities);
                int[] greedyRoute = GreedyMethod.greedyRoute(array1);
                int[] greedyItterativeRoute = GreedyItterative.greedyItterative(greedyRoute, array1);
                int[] GreedyItterativeRandom = GreedyItterative.greedyItterative(randomRoute, array1);
                int[] GreedyItterativeRandomItterative = GreedyItterative.greedyItterative(randomIntterativeRoute, array1);

                randomResult.Text = CalculateCost.calculateTotalCost(randomRoute, array1).ToString();
                itRandomResult.Text = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1).ToString();
                greedyResult.Text = CalculateCost.calculateTotalCost(greedyRoute, array1).ToString();
                GreedyItterativeResult.Text = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1).ToString();
                GRandomInputResult.Text = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1).ToString();
                GRandomItterativeResult.Text = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1).ToString();

                int itteration = 1000;
                int[] randomMethod = new int[itteration];
                int[] randomItterativeMethod = new int[itteration];
                int[] greedyMethod = new int[itteration];
                int[] greedyItterativeGreedy = new int[itteration];
                int[] greedyItterativeRandom = new int[itteration];
                int[] greedyItterativeRandomItterative = new int[itteration];
                double randomMethodMean = 0;
                double randomItterativeMethodMean = 0;
                double greedyMethodMean = 0;
                double greedyItterativeGreedyMean = 0;
                double greedyItterativeRandomMean = 0;
                double greedyItterativeItterativeRandomMean = 0;
                
                for (int i = 0; i < itteration; i++)
                {
                    randomRoute = RandomMethod.randMethod(array1, cities);
                    randomIntterativeRoute = RandomItterativeMethod.iterativeRndMethod(array1, cities);
                    greedyRoute = GreedyMethod.greedyRoute(array1);
                    greedyItterativeRoute = GreedyItterative.greedyItterative(greedyRoute, array1);
                    GreedyItterativeRandom = GreedyItterative.greedyItterative(randomRoute, array1);
                    GreedyItterativeRandomItterative = GreedyItterative.greedyItterative(randomIntterativeRoute, array1);

                    randomMethod[i] = CalculateCost.calculateTotalCost(randomRoute, array1);
                    randomMethodMean = randomMethodMean + CalculateCost.calculateTotalCost(randomRoute, array1);

                    randomItterativeMethod[i] = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                    randomItterativeMethodMean = randomItterativeMethodMean + CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);

                    greedyMethod[i] = CalculateCost.calculateTotalCost(greedyRoute, array1);
                    greedyMethodMean = greedyMethodMean + CalculateCost.calculateTotalCost(greedyRoute, array1);

                    greedyItterativeGreedy[i] = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                    greedyItterativeGreedyMean = greedyItterativeGreedyMean + CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);

                    greedyItterativeRandom[i] = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                    greedyItterativeRandomMean = greedyItterativeRandomMean + CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);

                    greedyItterativeRandomItterative[i] = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);
                    greedyItterativeItterativeRandomMean = greedyItterativeItterativeRandomMean + CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);
                }

                randomMethodMean = randomMethodMean/itteration;
                randomItterativeMethodMean = randomItterativeMethodMean/itteration;
                greedyMethodMean = greedyMethodMean/itteration;
                greedyItterativeGreedyMean = greedyItterativeGreedyMean/itteration;
                greedyItterativeRandomMean = greedyItterativeRandomMean/itteration;
                greedyItterativeItterativeRandomMean = greedyItterativeItterativeRandomMean/itteration;

                RandomMean.Text = randomMethodMean.ToString();
                RandomItterativeMean.Text = randomItterativeMethodMean.ToString();
                GreedyMean.Text = greedyMethodMean.ToString();
                GreedyItterativeGreedyMean.Text = greedyItterativeGreedyMean.ToString();
                GreedyItterativeRandomMean.Text = greedyItterativeRandomMean.ToString();
                GreedyItterativeRandomItterativeMean.Text = greedyItterativeItterativeRandomMean.ToString();





            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
