using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanPos
{
    public partial class menuUtama : MetroFramework.Forms.MetroForm
    {
        public menuUtama()
        {
            InitializeComponent();
        }

        private void menuUtama_Load(object sender, EventArgs e)
        {

        }


        private void barang_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Close();
        }
        private void customer_Click(object sender, EventArgs e)
        {
            menuCustomer mnc = new menuCustomer();
            mnc.Show();
            this.Close();
        }
    }
}
