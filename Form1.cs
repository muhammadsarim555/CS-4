using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber = 3;
            int secondNumber = 4;

            int sum = firstNumber + secondNumber;

            MessageBox.Show(sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float firstNumber = 3.5F;
            float secondNumber = 4.44F;

            float sum = firstNumber + secondNumber;

            MessageBox.Show(sum.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = 33.11;
            double n2 = 99.11;

            double sum = n1 + n2;

            MessageBox.Show(sum.ToString());
        }
    }
}
