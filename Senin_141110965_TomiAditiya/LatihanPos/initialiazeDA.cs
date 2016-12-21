using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LatihanPos
{
    class initialiazeDA
    {
            public string conn;
            public MySqlCommand insertBarang;
            public MySqlCommand insertCustomer;
            public MySqlConnection connect;
            public string barangSelectSql;
            public string customerSelectSql;
            public MySqlDataAdapter barangDA = new MySqlDataAdapter();
            public MySqlDataAdapter customerDA = new MySqlDataAdapter();


        public void db_connection()
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
          
        public void TampilBarang() {
                barangSelectSql = string.Concat("select * from tblbarang");
                barangDA.SelectCommand = new MySqlCommand(barangSelectSql, connect);
        }
        public void Barang(string kodeBarang, string namaBarang, string jlhAwal, string hargaHPP, string hargaJual,int kode) {
            string barangInsertSql = string.Concat("INSERT INTO tblbarang(kodeBarang,namaBarang,jlhAwal,hrgHPP,hrgJual,created_at,update_at)VALUES(@kodeBarang,@namaBarang,@jlhAwal,@hrgHPP,@hrgJual,@created_at,@update_at)");
            string barangUpdateSql = string.Concat("update tblbarang set namaBarang=@namaBarang,jlhAwal=@jlhAwal,hrgHPP=@hrgHPP,hrgJual=@hrgJual,update_at=@update_at where kodeBarang=@kodeBarang");
            string barangDeleteSql = string.Concat("delete from tblbarang where kodeBarang=@kodeBarang");
            if (kode == 0)
            {
                insertBarang = new MySqlCommand(barangInsertSql, connect);
            }
            else if (kode == 2) {
                insertBarang = new MySqlCommand(barangDeleteSql, connect);
            }
            else
            {
                insertBarang = new MySqlCommand(barangUpdateSql, connect);
            }
            insertBarang.Parameters.AddWithValue("@kodeBarang", kodeBarang);
            insertBarang.Parameters.AddWithValue("@namaBarang", namaBarang);
            insertBarang.Parameters.AddWithValue("@jlhAwal", int.Parse(jlhAwal));
            insertBarang.Parameters.AddWithValue("@hrgHPP", decimal.Parse(hargaHPP));
            insertBarang.Parameters.AddWithValue("@hrgJual", decimal.Parse(hargaJual));
            insertBarang.Parameters.AddWithValue("@created_at", DateTime.Now);
            insertBarang.Parameters.AddWithValue("@update_at", DateTime.Now);
        }
        public void TampilCustomer()
        {
            customerSelectSql = string.Concat("select * from tblcustomer");
            customerDA.SelectCommand = new MySqlCommand(customerSelectSql, connect);
        }
        public void Customer(string idcust, string nama, string alamat, string kodepos, string email,string nohp, int kode)
        {
            string customerInsertSql = string.Concat("INSERT INTO tblcustomer(idcust,nama,alamat,kodepos,email,nohp,created_at,updated_at)VALUES(@idcust,@nama,@alamat,@kodepos,@email,@nohp,@created_at,@update_at)");
            string customerUpdateSql = string.Concat("update tblcustomer set nama=@nama,kodepos=@kodepos,email=@email,nohp=@nohp,updated_at=@update_at where idcust=@idcust");
            string customerDeleteSql = string.Concat("delete from tblcustomer where idcust=@idcust");
            if (kode == 0)
            {
                insertCustomer = new MySqlCommand(customerInsertSql, connect);
            }
            else if (kode == 2)
            {
                insertCustomer = new MySqlCommand(customerDeleteSql, connect);
            }
            else
            {
                insertCustomer = new MySqlCommand(customerUpdateSql, connect);
            }
            insertCustomer.Parameters.AddWithValue("@idcust", idcust);
            insertCustomer.Parameters.AddWithValue("@nama", nama);
            insertCustomer.Parameters.AddWithValue("@alamat",alamat);
            insertCustomer.Parameters.AddWithValue("@kodepos", kodepos);
            insertCustomer.Parameters.AddWithValue("@email", email);
            insertCustomer.Parameters.AddWithValue("@nohp", nohp);
            insertCustomer.Parameters.AddWithValue("@created_at", DateTime.Now);
            insertCustomer.Parameters.AddWithValue("@update_at", DateTime.Now);
        }
    }
}

