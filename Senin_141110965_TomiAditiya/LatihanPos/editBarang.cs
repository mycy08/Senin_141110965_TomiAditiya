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
    public partial class editBarang : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        public editBarang()
        {
            InitializeComponent();
        }

        public editBarang(string kode,string nama,string jlh,string hpp,string jual)

        : this(){

            kodeBarang.Text = kode;
            namaBarang.Text = nama;
            jlhAwal.Text = jlh;
            hargaHPP.Text = hpp;
            hargaJual.Text = jual;

        }
        private void editBarang_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                da.db_connection();
                da.Barang(kodeBarang.Text, namaBarang.Text, jlhAwal.Text, hargaHPP.Text, hargaJual.Text, 1);
                da.insertBarang.ExecuteNonQuery();
                MessageBox.Show("1 Record telah di Edit");
                this.Close();


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

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Hide();
        }
    }
}