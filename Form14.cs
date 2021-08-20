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
    public partial class Form14 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D9UDA51;Initial Catalog=project;Integrated Security=True");
        SqlDataAdapter adapt;
        Int64 id;

        public Form14()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Table_2", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Form5.SetText1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Form2.SetValueForText2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Form3.a = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Form2.SetValueForText3 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Form3.b = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Form3.c = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Form6.seatno = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Form2.SetValueForText1 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
