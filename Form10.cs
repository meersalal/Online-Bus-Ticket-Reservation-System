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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg",imageNumber);
            imageNumber++;
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
           
            this.Location = new Point(0,0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                panel1.Visible = true;
                panel1.Width = 200;
                panel1.Height = 490;  
            }
            else
            {
                panel1.Visible = true;
                panel1.Width = 50;
                panel1.Height = 490;

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            if(panel1.Width == 50)
            {
                panel1.Visible = true;
                panel1.Width = 200;
                panel1.Height = 490;
            }
            else
            {
                panel1.Visible = true;
                panel1.Width = 50;
                panel1.Height = 490;
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            new Form12().Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            new Form13().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void slidePic_Click(object sender, EventArgs e)
        {

        }
    }
}
