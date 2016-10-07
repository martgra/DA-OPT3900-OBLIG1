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
                int randomMethodBest = 0;
                int randomItterativeMethodBest = 0;
                int greedyMethodBest = 0;
                int greedyItterativeGreedyBest = 0;
                int greedyItterativeRandomBest = 0;
                int greedyItterativeItterativeRandomBest = 0;

                randomMethodBest = CalculateCost.calculateTotalCost(randomRoute, array1);
                randomItterativeMethodBest = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                greedyMethodBest = CalculateCost.calculateTotalCost(greedyRoute, array1);
                greedyItterativeGreedyBest = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                greedyItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                greedyItterativeItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);

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
                    if (randomMethodBest > CalculateCost.calculateTotalCost(randomRoute, array1))
                    {
                        randomMethodBest = CalculateCost.calculateTotalCost(randomRoute, array1);
                    }

                    randomItterativeMethod[i] = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                    randomItterativeMethodMean = randomItterativeMethodMean + CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                    if (randomItterativeMethodBest > CalculateCost.calculateTotalCost(randomIntterativeRoute, array1))
                    {
                        randomItterativeMethodBest = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                    }


                    greedyMethod[i] = CalculateCost.calculateTotalCost(greedyRoute, array1);
                    greedyMethodMean = greedyMethodMean + CalculateCost.calculateTotalCost(greedyRoute, array1);
                    if (greedyMethodBest > CalculateCost.calculateTotalCost(greedyRoute, array1))
                    {
                        greedyMethodBest = CalculateCost.calculateTotalCost(greedyRoute, array1);
                    }


                    greedyItterativeGreedy[i] = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                    greedyItterativeGreedyMean = greedyItterativeGreedyMean + CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                    if (greedyItterativeGreedyBest > CalculateCost.calculateTotalCost(greedyItterativeRoute, array1))
                    {
                        greedyItterativeGreedyBest = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                    }

                    greedyItterativeRandom[i] = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                    greedyItterativeRandomMean = greedyItterativeRandomMean + CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                    if (greedyItterativeRandomBest > CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1))
                    {
                        greedyItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                    }


                    greedyItterativeRandomItterative[i] = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);
                    greedyItterativeItterativeRandomMean = greedyItterativeItterativeRandomMean + CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);

                    if (greedyItterativeItterativeRandomBest > CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1))
                    {
                        greedyItterativeItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);
                    }
                }

                randomMethodMean = randomMethodMean/itteration;
                randomItterativeMethodMean = randomItterativeMethodMean/itteration;
                greedyMethodMean = greedyMethodMean/itteration;
                greedyItterativeGreedyMean = greedyItterativeGreedyMean/itteration;
                greedyItterativeRandomMean = greedyItterativeRandomMean/itteration;
                greedyItterativeItterativeRandomMean = greedyItterativeItterativeRandomMean/itteration;

                randomResult.Text = randomMethodBest.ToString();
                itRandomResult.Text = randomItterativeMethodBest.ToString();
                greedyResult.Text = greedyMethodBest.ToString();
                GreedyItterativeResult.Text = greedyItterativeGreedyBest.ToString();
                GRandomInputResult.Text = greedyItterativeRandomBest.ToString();
                GRandomItterativeResult.Text = greedyItterativeItterativeRandomBest.ToString();

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
