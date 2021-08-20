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
    public partial class Form3 : Form
    {
        public static string a = "";
        public static string b = "";
        public static string c = "";
        public static string d = "";



        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


 

            new Form2().Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
          
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click_1(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label36_Click(object sender, EventArgs e)
        {
         
        }

        private void label17_Click(object sender, EventArgs e)
        {

      


            new Form4().Show();
            this.Hide();
        }

        private void label33_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label36_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label36_Click_2(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
            label36.Text = Form2.SetValueForText1;
            label34.Text = Form2.SetValueForText2;
            label35.Text = Form2.SetValueForText3;

            if (label34.Text == "Lahore " && label35.Text == "Karachi")
            {

                label9.Text = label9.Text + Convert.ToString(3500);
                label14.Text = label14.Text + Convert.ToString(3500);
                label19.Text = label19.Text + Convert.ToString(3500);
                label24.Text = label24.Text + Convert.ToString(3500);
                label29.Text = label29.Text + Convert.ToString(3500);
                label11.Text = "3500";
                label16.Text = "3500";
                label21.Text = "3500";
                label26.Text = "3500";
                label31.Text = "3500";


            }
            else if (label34.Text == "Lahore " && label35.Text == "Pheshawar")
            {
                label9.Text = label9.Text + Convert.ToString(1500);
                label14.Text = label14.Text + Convert.ToString(1500);
                label19.Text = label19.Text + Convert.ToString(1500);
                label24.Text = label24.Text + Convert.ToString(1500);
                label29.Text = label29.Text + Convert.ToString(1500);
                label11.Text = "1500";
                label16.Text = "1500";
                label21.Text = "1500";
                label26.Text = "1500";
                label31.Text = "1500";
            }
             else if (label34.Text == "Lahore " && label35.Text == "Sakhar")
            {
                label9.Text = label9.Text + Convert.ToString(1500);
                label14.Text = label14.Text + Convert.ToString(1500);
                label19.Text = label19.Text + Convert.ToString(1500);
                label24.Text = label24.Text + Convert.ToString(1500);
                label29.Text = label29.Text + Convert.ToString(1500);
                label11.Text = "1500";
                label16.Text = "1500";
                label21.Text = "1500";
                label26.Text = "1500";
                label31.Text = "1500";
            }
             else if (label34.Text == "Lahore " && label35.Text == "sakardu")
            {
                label9.Text = label9.Text + Convert.ToString(4500);
                label14.Text = label14.Text + Convert.ToString(4500);
                label19.Text = label19.Text + Convert.ToString(4500);
                label24.Text = label24.Text + Convert.ToString(4500);
                label29.Text = label29.Text + Convert.ToString(4500);
                label11.Text = "4500";
                label16.Text = "4500";
                label21.Text = "4500";
                label26.Text = "4500";
                label31.Text = "4500";
            }
            else if (label34.Text == "Lahore " && label35.Text == "larkahna")
            {
                label9.Text = label9.Text + Convert.ToString(3000);
                label14.Text = label14.Text + Convert.ToString(3000);
                label19.Text = label19.Text + Convert.ToString(3000);
                label24.Text = label24.Text + Convert.ToString(3000);
                label29.Text = label29.Text + Convert.ToString(3000);
                label11.Text = "3000";
                label16.Text = "3000";
                label21.Text = "3000";
                label26.Text = "3000";
                label31.Text = "3000";
               
            }
            else if (label34.Text == "Lahore " && label35.Text == "Laya")
            {
                label9.Text = label9.Text + Convert.ToString(2000);
                label14.Text = label14.Text + Convert.ToString(2000);
                label19.Text = label19.Text + Convert.ToString(2000);
                label24.Text = label24.Text + Convert.ToString(2000);
                label29.Text = label29.Text + Convert.ToString(2000);
                label11.Text = "2000";
                label16.Text = "2000";
                label21.Text = "2000";
                label26.Text = "2000";
                label31.Text = "2000";
            }
            else if (label34.Text == "Lahore " && label35.Text == "Haripur")
            {
                label9.Text = label9.Text + Convert.ToString(1700);
                label14.Text = label14.Text + Convert.ToString(1700);
                label19.Text = label19.Text + Convert.ToString(1700);
                label24.Text = label24.Text + Convert.ToString(1700);
                label29.Text = label29.Text + Convert.ToString(1700);
                label11.Text = "1700";
                label16.Text = "1700";
                label21.Text = "1700";
                label26.Text = "1700";
                label31.Text = "1700";
            }


            a = label12.Text;
            b = label8.Text;
            c = label9.Text;

          




        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            a = label12.Text;
            b = label8.Text;
            new Form4().Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {





            new Form4().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {



            new Form4().Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {



            new Form4().Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            c = label9.Text;
            d = label11.Text;
            new Form4().Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {



            new Form4().Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {



            new Form4().Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        { 


            new Form4().Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {



            new Form4().Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {




            new Form4().Show();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {

            new Form4().Show();
            this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void label29_Click(object sender, EventArgs e)
        {

            new Form4().Show();
            this.Hide();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }






    }
}
