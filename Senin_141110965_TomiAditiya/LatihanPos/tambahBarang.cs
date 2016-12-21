﻿using System;
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
        initialiazeDA da = new initialiazeDA();
        public tambahBarang()
        {
            InitializeComponent();
        }
       
        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuUtama mn = new menuUtama();
            mn.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            da.db_connection();
            MySqlCommand count = da.connect.CreateCommand();
            count.CommandText = "SELECT COUNT(*) FROM tblbarang where kodeBarang='"+kodeBarang.Text+"' ";
            int hit = Convert.ToInt32(count.ExecuteScalar());
            if (hit >= 1)
            {
                MessageBox.Show("Kode Barang sudah terdaftar");
            }
            else
            {
                try
                {
                    da.Barang(kodeBarang.Text, namaBarang.Text, jlhAwal.Text, hargaHPP.Text, hargaJual.Text,0);
                    da.insertBarang.ExecuteNonQuery();
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
                    if (da.connect.State == ConnectionState.Open)
                    {
                        da.connect.Close();
                    }
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