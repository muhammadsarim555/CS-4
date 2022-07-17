namespace assignment1_fabonacci
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = "";

            Int32 fN = 0;
            Int32 lN = 1;
            Int32 add = 0;
            Int32 n = Int32.Parse(textBox1.Text);

            for (Int32 i = 1; i <= n; i++)
            {
                add = fN + lN;
                fN = lN;
                lN = add;


                //label1.Text = fN + lN.ToString();
                label2.Text = label2.Text + " " + add.ToString();
             
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}