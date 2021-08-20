using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    MailMessage msg = new MailMessage();
            //    msg.From = new MailAddress("meersalal1@gmail.com");
            //    msg.To.Add("meersalal1@gmail.com");
            //    msg.Subject = "Complains";
            //    msg.Body = richTextBox1.Text;

            //    SmtpClient smt = new SmtpClient();
            //    smt.Host = "smtp.gmail.com";
            //    System.Net.NetworkCredential ntcd = new NetworkCredential();
            //    ntcd.UserName = "nilusilu3@gmail.com";
            //    ntcd.Password = "";
            //    smt.Credentials = ntcd;
            //    smt.EnableSsl = true;
            //    smt.Port = 587;
            //    smt.Send(msg);

            //    MessageBox.Show("Your Mail is sended");

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}  
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
