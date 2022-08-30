namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int N = 0;
        int M = 0;
        int mode = 0;//1- subtraction( - )
                     //2- addition( + )
                     //3- multiply( * )
                     //4- divide( / ) 

        private void subtraction_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            mode = 1;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            mode = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            mode = 3;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            mode = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}