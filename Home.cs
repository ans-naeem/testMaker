using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testMaker
{
    public partial class Home : Form
    {
        //int id;
        string subject;
        public Home()
        {
            InitializeComponent();
        }
        //when 9th class button clicked after choosing subject
        private void button1_Click(object sender, EventArgs e)
        {
            string val = "9";
            //subject = (dataGridView1.Rows[0].Cells[0].Value).ToString();

            questiontype s = new questiontype(val,subject);
            s.Show();
        }
        //when 10th class button clicked after choosing subject

        private void button2_Click(object sender, EventArgs e)
        {
            string val = "10";
            //subject = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value).ToString();
            questiontype s = new questiontype(val,subject);

           // questiontype s = new questiontype(val);
            s.Show();
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

        //}


        private void Home_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LK0KV1I\SQLEXPRESS;Initial Catalog=testmaker;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from subjects", con);
            DataTable dt = new DataTable();
            //con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            subject = (dataGridView1.SelectedRows[0].Cells[1].Value).ToString();

        }


        //private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    subject = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value).ToString();

        //}
    }

}
