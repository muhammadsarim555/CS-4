using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            Int32 age = Int32.Parse(textBox2.Text);
            string gender = textBox3.Text;
            double height = double.Parse(textBox4.Text);
            string cnic = textBox5.Text;
            string address = textBox6.Text;



            MessageBox.Show("Your Name is " + name + "\n" + "Your Age is " + age.ToString()
                + "\n" + "Your gender is " + gender
                 + "\n" + "Your height is " + height
                 + "\n" + "Your cnic is " + cnic
                 + "\n" + "Your address is " + address
                );
            //MessageBox.Show();
            //label2.Text = "Your Name is " + name + "\n" + "Your Age is " + age;
            //label2.Text = ;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
