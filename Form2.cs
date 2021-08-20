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
    public partial class Form2 : Form
    {

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(dateTimePicker1.Value.ToLongDateString());
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SetValueForText1 = comboBox1.Text;
            SetValueForText2 = comboBox2.Text;
            SetValueForText3 = comboBox3.Text; 

            if (SetValueForText1 == "" && SetValueForText2 == "" && SetValueForText3 == "")
            {
                MessageBox.Show("Select the Travel Date , Departure terminal and Arrival terminal", "Error");
                
            }
            else if ( SetValueForText2 == "" && SetValueForText3 == "")
            {
                MessageBox.Show("Select the Departure terminal and Arrival terminal", "Error");
                
            }
            else if (SetValueForText1 == "" && SetValueForText3 == "")
            {
                MessageBox.Show("Select the Travel Date and Arrival terminal", "Error");
                
            }
            else if (SetValueForText1 == "" && SetValueForText2 == "")
            {
                MessageBox.Show("Select the Travel Date and Departure terminal", "Error");
               
            }
           else  if(SetValueForText1 == "")
            {
                MessageBox.Show("Select the Travel Date", "Error");
               
            }
            else if (SetValueForText2 == "")
            {
                MessageBox.Show("Select Departure Terminal", "Error");
               
            }
            else if (SetValueForText3 == "")
            {
                MessageBox.Show("Select Arrival Terminal", "Error");
                
            }

            else if ( SetValueForText1 != "" &&  SetValueForText2 != "" &&  SetValueForText3 != "")
            {
                new Form3().Show();
                this.Hide();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
