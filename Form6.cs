using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication3
{
    public partial class Form6 : Form
    {
        public static string p1 = "";
        public static string p2 = "";
        public static string p3 = "";
        public static string p4 = "";
        public static string p5 = "";
        public static string p6 = "";
        public static string p7 = "";
        public static string p8 = "";
        public static string p9 = "";
        public static string p10 = "";
        public static string p11 = "";
        public static string p12 = "";
        public static string p13 = "";
        public static string p14 = "";
        public static string p15 = "";
        public static string p16 = "";
        public static string p17 = "";
        public static string seatno = "";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D9UDA51;Initial Catalog=project;Integrated Security=True");
        SqlCommand cmd;


        public Form6()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            p1 = Convert.ToString(Form4.Value1);
            p2 = Convert.ToString(Form4.Value2);
            p3 = Convert.ToString(Form4.Value3);
            p4 = Convert.ToString(Form4.Value4);
            p5 = Convert.ToString(Form4.Value5);
            p6 = Convert.ToString(Form4.Value6);
            p7 = Convert.ToString(Form4.Value7);
            p8 = Convert.ToString(Form4.Value8);
            p9 = Convert.ToString(Form4.Value9);
            p10 = Convert.ToString(Form4.Value10);
            p11 = Convert.ToString(Form4.Value11);
            p12 = Convert.ToString(Form4.Value12);
            p13 = Convert.ToString(Form4.Value13);
            p14 = Convert.ToString(Form4.Value14);
            p15 = Convert.ToString(Form4.Value15);
            p16 = Convert.ToString(Form4.Value16);
            p17 = Convert.ToString(Form4.Value17);
         
         
                if (Form4.Value1 != 0)
                {
                    label16.Text = label16.Text + p1;
                    label16.Text = label16.Text + ",";
                }
                if (Form4.Value2 != 0)
                {
                    label16.Text = label16.Text + p2;
                    label16.Text = label16.Text + ",";
                }
                 if (Form4.Value3 != 0)
                {
                    label16.Text = label16.Text + p3;
                    label16.Text = label16.Text + ",";
                }
                 if (Form4.Value4 != 0)
                 {
                     label16.Text = label16.Text + p4;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value5 != 0)
                 {
                     label16.Text = label16.Text + p5;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value6 != 0)
                 {
                     label16.Text = label16.Text + p6;
                     label16.Text = label16.Text + ",";
                 }

                 if (Form4.Value7 != 0)
                 {
                     label16.Text = label16.Text + p7;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value8 != 0)
                 {
                     label16.Text = label16.Text + p8;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value9 != 0)
                 {
                     label16.Text = label16.Text + p9;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value10 != 0)
                 {
                     label16.Text = label16.Text + p10;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value11 != 0)
                 {
                     label16.Text = label16.Text + p11;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value12 != 0)
                 {
                     label16.Text = label16.Text + p12;
                     label16.Text = label16.Text + ",";
                 }

                 if (Form4.Value13 != 0)
                 {
                     label16.Text = label16.Text + p13;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value14 != 0)
                 {
                     label16.Text = label16.Text + p14;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value15 != 0)
                 {
                     label16.Text = label16.Text + p15;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value16 != 0)
                 {
                     label16.Text = label16.Text + p16;
                     label16.Text = label16.Text + ",";
                 }
                 if (Form4.Value17 != 0)
                 {
                     label16.Text = label16.Text + p17;
                     label16.Text = label16.Text + ",";
                 }

          

            label10.Text = Form5.SetText1;
            label11.Text = Form2.SetValueForText2;
            label12.Text = Form3.a;
            label13.Text = Form2.SetValueForText3;
            
            label14.Text = Form3.b;
            label15.Text = Form3.c;



            label17.Text =  Form2.SetValueForText1;
            seatno = label16.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (Form5.SetText1 != "" && Form2.SetValueForText2 != "" && Form3.a != "" && Form2.SetValueForText3 != "" && Form3.b != "" && Form3.c != "" && seatno != "" && Form2.SetValueForText1 != "")
            {



                cmd = new SqlCommand("insert into Table_2 (Passanger_Name,Departure_Name,Departure_Time,Arrival_Name,Arrival_Time,Total_Fare,Seat,Date) values(@Passanger_Name,@Departure_Name,@Departure_Time,@Arrival_Name,@Arrival_Time,@Total_Fare,@Seat,@Date)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Passanger_Name", Form5.SetText1);
                cmd.Parameters.AddWithValue("@Departure_Name", Form2.SetValueForText2);
                cmd.Parameters.AddWithValue("@Departure_Time", Form3.a);
                cmd.Parameters.AddWithValue("@Arrival_Name", Form2.SetValueForText3);
                cmd.Parameters.AddWithValue("@Arrival_Time", Form3.b);
                cmd.Parameters.AddWithValue("@Total_Fare", Form3.c);
                cmd.Parameters.AddWithValue("@Seat", seatno);
                cmd.Parameters.AddWithValue("@Date", Form2.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
