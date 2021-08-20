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
    public partial class Form9 : Form
    {
        public static string l1 = "";
        public static string l2 = "";
        public static string l3 = "";
        public static string l4 = "";
        public static string l5 = "";
        public static string l6 = "";
        public static string l7 = "";
        public static string l8 = "";
        public static string l9 = "";
        public static string l10 = "";
        public static string l11 = "";
        public static string l12 = "";
        public static string l13 = "";
        public static string l14 = "";
        public static string l15 = "";
        public static string l16 = "";
        public static string l17 = "";



        public Form9()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

           

            l1 = Convert.ToString(Form4.Value1);
            l2 = Convert.ToString(Form4.Value2);
            l3 = Convert.ToString(Form4.Value3);
            l4 = Convert.ToString(Form4.Value4);
            l5 = Convert.ToString(Form4.Value5);
            l6 = Convert.ToString(Form4.Value6);
            l7 = Convert.ToString(Form4.Value7);
            l8 = Convert.ToString(Form4.Value8);
            l9 = Convert.ToString(Form4.Value9);
            l10 = Convert.ToString(Form4.Value10);
            l11 = Convert.ToString(Form4.Value11);
            l12 = Convert.ToString(Form4.Value12);
            l13 = Convert.ToString(Form4.Value13);
            l14 = Convert.ToString(Form4.Value14);
            l15 = Convert.ToString(Form4.Value15);
            l16 = Convert.ToString(Form4.Value16);
            l17 = Convert.ToString(Form4.Value17);
          

            if (Form4.Value1 != 0)
            {
                label7.Text = label7.Text + l1;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value2 != 0)
            {
                label7.Text = label7.Text + l2;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value3 != 0)
            {
                label7.Text = label7.Text + l3;
                 label7.Text = label7.Text + ",";
            }
            if (Form4.Value4 != 0)
            {
                label7.Text = label7.Text + l4;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value5 != 0)
            {
                label7.Text = label7.Text + l5;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value6 != 0)
            {
                label7.Text = label7.Text + l6;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value7 != 0)
            {
                label7.Text = label7.Text + l7;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value8 != 0)
            {
                label7.Text = label7.Text + l8;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value9 != 0)
            {
                label7.Text = label7.Text + l9;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value10 != 0)
            {
                label7.Text = label7.Text + l10;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value11 != 0)
            {
                label7.Text = label7.Text + l11;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value12 != 0)
            {
                label7.Text = label7.Text + l12;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value13 != 0)
            {
                label7.Text = label7.Text + l13;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value14 != 0)
            {
                label7.Text = label7.Text + l14;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value15 != 0)
            {
                label7.Text = label7.Text + l15;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value16 != 0)
            {
                label7.Text = label7.Text + l16;
                label7.Text = label7.Text + ",";
            }
            if (Form4.Value17 != 0)
            {
                label7.Text = label7.Text + l17;
                label7.Text = label7.Text + ",";
            }
            


            
            label5.Text = Form2.SetValueForText2;
            label13.Text = Form2.SetValueForText3;
            label9.Text = Form2.SetValueForText1;
            label11.Text = Form3.a;
            label3.Text = Form5.SetText1;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap b = Properties.Resources._6bc5f74d_c612_49f5_bfd1_11b818018437;
            Image my = b;
            e.Graphics.DrawImage(my,380,0,100,100);

            e.Graphics.DrawString("Royal Express",new Font("Arial",14,FontStyle.Regular),Brushes.Black,new Point(365,100) );
            e.Graphics.DrawString("Name :" + label3.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 150));
            e.Graphics.DrawString("Seats :" + label7.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 200));
            e.Graphics.DrawString("Departure :" + label5.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 250));
            e.Graphics.DrawString("Arrival :" + label13.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 300));
            e.Graphics.DrawString("Date :" + label9.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 350));
            e.Graphics.DrawString("Time :" + label11.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 400));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
