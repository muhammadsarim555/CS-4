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
    public partial class Form3 : Form
    {
        double total1 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        string theOperator;

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double total2 = 0;


            switch (theOperator)
            {
                case "+":
                    total2 = total1 + double.Parse(textBox1.Text);
                        break;
                    case "-":
                    total2 = total1 - double.Parse(textBox1.Text);
                        break;
                     case "*":
                    total2 = total1 * double.Parse(textBox1.Text);
                        break;
                         case "/":
                    total2 = total1 / double.Parse(textBox1.Text);
                        break;
                default: 
                        
                    MessageBox.Show("Please Select Operation!");
                    break;
                
            }

            //if (plusButtonClicked == true)
            //{
            //    total2 = total1 + double.Parse(textBox1.Text);
            
            //}
            //else if (minusButtonClicked == true)
            //{
            //    total2 = total1 - double.Parse(textBox1.Text);

            //    //WRITE CODE TO SUBTRACT HERE
            //}
            //else if(multiplyButtonClicked == true)
            //{
            //    total2 = total1 * double.Parse(textBox1.Text);

            //}
            //else if (divideButtonClicked == true)
            //{
            //    total2 = total1 / double.Parse(textBox1.Text);

            //}
            
            
                textBox1.Text = total2.ToString();
            total1 = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(textBox1.Text);

            minusButtonClicked = false;
            plusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            theOperator = "+";

            textBox1.Clear();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            
            minusButtonClicked= true;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            theOperator = "-";


            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);

            minusButtonClicked = false;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
            theOperator = "*";


           textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);

            minusButtonClicked = false;
            plusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
            theOperator = "/";

            textBox1.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
