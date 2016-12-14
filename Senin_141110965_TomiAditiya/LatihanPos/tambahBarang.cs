using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanPos
{
    public partial class tambahBarang : MetroFramework.Forms.MetroForm
    {
      
        public tambahBarang()
        {
            InitializeComponent();
        }
       
        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuUtama mn = new menuUtama();
            mn.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=posapp;Uid=root;Pwd=");
            MySqlCommand cmd;
            connection.Open();
            MySqlCommand count = connection.CreateCommand();
            count.CommandText = "SELECT * FROM tblbarang " ;
            MySqlDataReader mycount;
            mycount = count.ExecuteReader();
            while (mycount.Read())
            {
               
                if (mycount.GetString(1) == kodeBarang.Text)
                {
                    MessageBox.Show("Kode Barang sudah terdaftar");
                    mycount.Close();
                    connection.Close();
                    break;
                }
                else
                {
                    mycount.Close();
                    try
                    {
                        
                        cmd = connection.CreateCommand();
                        cmd.CommandText = "INSERT INTO tblbarang(kodeBarang,namaBarang,jlhAwal,hrgHPP,hrgJual,created_at,update_at)VALUES(@kodeBarang,@namaBarang,@jlhAwal,@hrgHPP,@hrgJual,@created_at,@update_at)";
                        cmd.Parameters.AddWithValue("@kodeBarang", kodeBarang.Text);
                        cmd.Parameters.AddWithValue("@namaBarang", namaBarang.Text);
                        cmd.Parameters.AddWithValue("@jlhAwal", int.Parse(jlhAwal.Text));
                        cmd.Parameters.AddWithValue("@hrgHPP", decimal.Parse(hargaHPP.Text));
                        cmd.Parameters.AddWithValue("@hrgJual", decimal.Parse(hargaJual.Text));
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@update_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("1 Record tersimpan");
                        kodeBarang.Text = "";
                        namaBarang.Text = "";
                        jlhAwal.Text = "";
                        hargaHPP.Text = "";
                        hargaJual.Text = "";


                    }
                    catch (Exception)
                    {
                        throw;
                        

                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                    break;
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            kodeBarang.Text = "";
            namaBarang.Text = "";
            jlhAwal.Text = "";
            hargaHPP.Text = "";
            hargaJual.Text = "";
        }
    }
}
