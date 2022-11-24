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
    public partial class questiontype : Form
    {
        string val,subject;
        int id;
        public questiontype(string val)
        {
            this.val = val;
            InitializeComponent();
        }
        public questiontype(string val,string subject)
        {
            this.val = val;
            this.subject = subject;
            InitializeComponent();
        }


        private void subjects_Load(object sender, EventArgs e)
        {
            labelClass.Text = val;

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LK0KV1I\SQLEXPRESS;Initial Catalog=testmaker;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select subject FROM subjects WHERE ID=@id", con);
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@id", id);            
            //DataTable dt = new DataTable();
            ////con.Open();
            //SqlDataReader rd = cmd.ExecuteReader();
            //dt.Load(rd);
            //con.Close();
            labelclass2.Text = subject;
        }
    }
}
