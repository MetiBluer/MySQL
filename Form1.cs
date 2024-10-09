using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DB_ACT1_046_Tolentino_Francesz
{
    public partial class Main : Form
    {
        string connStr = "server=localhost; database=db_act1; uid=root; pwd=uslt; port=3306";
        MySqlConnection conn;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn = new MySqlConnection(connStr);
            string query = "select * from car where model= '" + txtKeyword.Text + "' and brand '" + cboBrand.Text + "' ";
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            grdResult.DataSource = dt;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn = new MySqlConnection(connStr);
            string query = "select * from car where model= '" + txtKeyword.Text + "' and brand '" + cboBrand.Text + "' ";
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            grdResult.DataSource = dt;
        }
    }
}
