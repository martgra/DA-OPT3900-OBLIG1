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
            int[,] array1 = GenerateGraph.generateGraph(cites);
            randomResult.Text = CalculateCost.calculateTotalCost((RandomMethod.randMethod(array1, cites)), array1).ToString();
            itRandomResult.Text = CalculateCost.calculateTotalCost((RandomItterativeMethod.iterativeRndMethod(array1, cites)), array1).ToString();
            greedyResult.Text = CalculateCost.calculateTotalCost((GreedyMethod.greedyRoute(array1)),array1).ToString();

            
        }
        
    }
}
