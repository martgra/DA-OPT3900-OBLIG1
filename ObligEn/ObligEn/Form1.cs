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
