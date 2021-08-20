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
    public partial class Form11 : Form
    {
        public static string la = "";
        public static string k = "";

        public Form11()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            la = Form5.SetText1;

            if (textBox1.Text == Form5.SetText1 && textBox2.Text == Form5.SetText2)
            {
                MessageBox.Show(" Your Booking is Seccussfull" ,"Booking");
                Form4.Value1 = 0;
                Form4.Value2 = 0;
                Form4.Value3 = 0;
                Form4.Value4 = 0;
                Form4.Value5 = 0;
                Form4.Value6 = 0;
                Form4.Value7 = 0;
                Form4.Value8 = 0;
                Form4.Value9 = 0;
                Form4.Value10 = 0;
                Form4.Value11 = 0;
                Form4.Value12 = 0;
                Form4.Value13 = 0;
                Form4.Value14 = 0;
                Form4.Value15 = 0;
                Form4.Value16 = 0;
                Form4.Value17 = 0;
                
                Form2.SetValueForText2 = null;
                Form2.SetValueForText3 = null;
                Form2.SetValueForText1 =null;
                Form3.a = null;
                Form5.SetText1 = null;



            }
            else if (textBox1.Text != Form5.SetText1)
            {
                MessageBox.Show("Enter Invalid Name","Error");
            }
            else if (textBox2.Text != Form5.SetText2)
            {
                MessageBox.Show("Enter Invalid Phone No", "Error");
            }

            


        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

    }
}
