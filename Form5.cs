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
    public partial class Form5 : Form
    {
        public static string SetText1 = "";
        public static string SetText2 = "";
   
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetText1 = textBox1.Text;
            SetText2 = textBox2.Text;

            if (SetText1 == "")
            {
                MessageBox.Show("Enter the Name","Error");
                new Form5().Show();
                this.Hide();
            }
            else if (SetText2 == "")
            {
                MessageBox.Show("Enter the Phone Number","Error");
                new Form5().Show();
                this.Hide();
            }

            else if (SetText1 != "" || SetText2 != "")
            {

                new Form6().Show();
                this.Hide();
            }

 

            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

