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

       


        string kodebarang, namabarang, hargajual, hargahpp, jlhawal;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            kodebarang = rows.Cells[1].Value.ToString();
            namabarang = rows.Cells[2].Value.ToString();
            jlhawal = rows.Cells[3].Value.ToString();
            hargahpp = rows.Cells[4].Value.ToString();
            hargajual = rows.Cells[5].Value.ToString();

           
        }
        private void mthapus_Click(object sender, EventArgs e)
        {
            db_connection();
            DialogResult pesan;
            pesan = MessageBox.Show("Anda Yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {

                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "delete from tblbarang where kodeBarang='" + kodebarang + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");



                }
                catch (Exception)
                {
                    throw;


                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void mtubah_Click(object sender, EventArgs e)
        {
            editBarang edt = new editBarang(kodebarang, namabarang, jlhawal, hargahpp, hargajual);
            edt.Show();
        }
    }
}
