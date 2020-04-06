using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomAverages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private double computeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();

            for (long values = 0; values < noOfValues; values++)
            {
                total += rand.NextDouble();
            }

            return total / noOfValues;
        }

        private void CalculateRandomAverages_Click(object sender, EventArgs e)
        {
            long noOfValues = 0;
            long.TryParse(textBox1.Text, out noOfValues);
            RandomAverageResults.Text = computeAverages(noOfValues).ToString();
        }
        
        private async void CalculateRandomAveragesAsync_Click(object sender, EventArgs e)
        {
            RandomAverageResults.Text = "Calculating";
            long noOfValues = 0;
            long.TryParse(textBox1.Text, out noOfValues);
            double result = await asyncComputeAverages(noOfValues);
            RandomAverageResults.Text = result.ToString();
        }

        private Task<double> asyncComputeAverages(long noOfValues)
        {
            return Task<double>.Run(() => 
                computeAverages(noOfValues)
            );
        }
    }
}
