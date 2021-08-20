using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public static int Value1 = 0  ;
        public static int Value2 = 0;
        public static int Value3 = 0;
        public static int Value4 = 0;
        public static int Value5 = 0;
        public static int Value6 = 0;
        public static int Value7 = 0;
        public static int Value8 = 0;
        public static int Value9 = 0;
        public static int Value10 = 0;
        public static int Value11 = 0;
        public static int Value12 = 0;
        public static int Value13 = 0;
        public static int Value14 = 0;
        public static int Value15 = 0;
        public static int Value16 = 0;
        public static int Value17 = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Value2 = 2;

            textBox1.Text =textBox1.Text + Convert.ToString(Value2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Value1 =  1;

            textBox1.Text = textBox1.Text + Convert.ToString(Value1);
            

        }
        private void button2_Click(object sender, EventArgs e)
        {

            Value3 =  3;

            textBox1.Text = textBox1.Text + Convert.ToString(Value3);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Value5 = 5;

            textBox1.Text = textBox1.Text + Convert.ToString(Value5);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Value7 = 7;

            textBox1.Text = textBox1.Text + Convert.ToString(Value7);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Value9 = 9;

            textBox1.Text = textBox1.Text + Convert.ToString(Value9);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Value11 = 11;

            textBox1.Text = textBox1.Text + Convert.ToString(Value11);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Value13 = 13;

            textBox1.Text = textBox1.Text + Convert.ToString(Value13);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Value15 = 15;

            textBox1.Text = textBox1.Text + Convert.ToString(Value15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Value16 = 16;

            textBox1.Text = textBox1.Text + Convert.ToString(Value16);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Value17 = 17;

            textBox1.Text = textBox1.Text + Convert.ToString(Value17);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Value14 = 14;

            textBox1.Text = textBox1.Text + Convert.ToString(Value14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Value12 = 12;

            textBox1.Text = textBox1.Text + Convert.ToString(Value12);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Value10 = 10;

            textBox1.Text = textBox1.Text + Convert.ToString(Value10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Value8 = 8;

            textBox1.Text = textBox1.Text + Convert.ToString(Value8);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Value6 = 6;

            textBox1.Text = textBox1.Text + Convert.ToString(Value6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Value4 = 4;

            textBox1.Text = textBox1.Text + Convert.ToString(Value4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            if(m == "")
            {
                MessageBox.Show("Select the seat No","Error");
                new Form4().Show();
                this.Hide();

            }
            else if(m != "")
            {

                new Form5().Show();
                this.Hide();
            }
         

          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
