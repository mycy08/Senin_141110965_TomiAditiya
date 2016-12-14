using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LatihanPos
{
    public partial class menuBarang : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        public menuBarang()
        {
            InitializeComponent();
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=posapp;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private void mlback_Click(object sender, EventArgs e)
        {
            menuUtama mn = new menuUtama();
            mn.Show();
            this.Hide();
        }

        private void mttambah_Click(object sender, EventArgs e)
        {
            using (tambahBarang tmbh = new tambahBarang()) {
                tmbh.ShowDialog();
            }
        }

        private void menuBarang_Load(object sender, EventArgs e)
        {
            db_connection();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM tblbarang";
            
            
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "data");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "data";

            connect.Close();
        }
        
        private void mlrefresh_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM tblbarang";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            
        }

        private void mthapus_Click(object sender, EventArgs e)
        {

        }
    }
}
