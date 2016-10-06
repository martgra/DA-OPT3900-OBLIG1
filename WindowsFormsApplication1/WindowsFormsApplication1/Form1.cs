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
            int[,] array1 = GenerateGraph.generateGraph(size);
            // array.Text = printGraph(array1, size);
            totalCost.Text = CalculateCost.calculateTotalCost(RandomMethod.randMethod(array1, size),array1).ToString();
            minCost.Text = CalculateCost.calculateTotalCost(RandomItterativeMethod.iterativeRndMethod(array1, size), array1).ToString();
            greedy.Text = CalculateCost.calculateTotalCost(GreedyMethod.greedyRoute(array1), array1).ToString();
            label4.Text = CalculateCost.calculateTotalCost(GreedyItterative.greedyItterative(GreedyMethod.greedyRoute(array1),array1), array1).ToString();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void greedy_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}