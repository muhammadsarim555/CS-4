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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNum = 22;
            int secNum = 8;

            int sum = firstNum - secNum;

            MessageBox.Show(sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstNum = 101.9;
            double secondNum = 1.9;

            double sum = firstNum - secondNum;

            MessageBox.Show(sum.ToString() );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float firstNum = 1000.7F;
            float secondNum = 0.7F;

            float sum = firstNum - secondNum;

            MessageBox.Show(sum.ToString());
        }
    }
}
