using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [,] array = Ran_Method.generateArray(20);
            label1.Text = "\n";
            string hello = " ";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    hello = array[i, j].ToString();
                    label1.Text += string.Format("{0, -3}\t", hello);
                }
                label1.Text += "\n";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "nei";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
