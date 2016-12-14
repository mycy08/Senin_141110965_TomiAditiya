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
    public partial class editBarang : MetroFramework.Forms.MetroForm
    {
        public editBarang()
        {
            InitializeComponent();
        }

        public editBarang(string kode,string nama,string jlh,string hpp,string jual)

        : this()

{

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
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=posapp;Uid=root;Pwd=");
            MySqlCommand cmd;
            
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "update tblbarang set namaBarang=@namaBarang,jlhAwal=@jlhAwal,hrgHPP=@hrgHPP,hrgJual=@hrgJual,update_at=@update_at where kodeBarang=@kodeBarang";
                cmd.Parameters.AddWithValue("@kodeBarang", kodeBarang.Text);
                cmd.Parameters.AddWithValue("@namaBarang", namaBarang.Text);
                cmd.Parameters.AddWithValue("@jlhAwal", int.Parse(jlhAwal.Text));
                cmd.Parameters.AddWithValue("@hrgHPP", decimal.Parse(hargaHPP.Text));
                cmd.Parameters.AddWithValue("@hrgJual", decimal.Parse(hargaJual.Text));
                
                cmd.Parameters.AddWithValue("@update_at", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("1 Record telah di Edit");
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
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Hide();
        }
    }
}
