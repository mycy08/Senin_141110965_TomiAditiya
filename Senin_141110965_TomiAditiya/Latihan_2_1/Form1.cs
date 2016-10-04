using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime my = new DateTime(2016, 6, 6);
            monthCalendar1.AddAnnuallyBoldedDate(my);
            
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            int bln1=0;

            if (bln.Text == "Januari")
                bln1 = 1;
            else if (bln.Text == "Febuari")
                bln1 = 2;
            else if (bln.Text == "Maret")
                bln1 = 3;
            else if (bln.Text == "April")
                bln1 = 4;
            else if (bln.Text == "Mei")
                bln1 = 5;
            else if (bln.Text == "Juni")
                bln1 = 6;
            else if (bln.Text == "Juli")
                bln1 = 7;
            else if (bln.Text == "Agustus")
                bln1 = 8;
            else if (bln.Text == "September")
                bln1 = 9;
            else if (bln.Text == "Oktober")
                bln1 = 10;
            else if (bln.Text == "November")
                bln1 = 11;
            else if (bln.Text == "Desember")
                bln1 = 12;
            else
                bln1 = 0;
            DateTime my = new DateTime(2016, bln1, (int)tgl.Value);
            monthCalendar1.AddAnnuallyBoldedDate(my);
            
            
        }

        private void bln_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            int bln1 = 0;

            if (bln.Text == "Januari")
                bln1 = 1;
            else if (bln.Text == "Febuari")
                bln1 = 2;
            else if (bln.Text == "Maret")
                bln1 = 3;
            else if (bln.Text == "April")
                bln1 = 4;
            else if (bln.Text == "Mei")
                bln1 = 5;
            else if (bln.Text == "Juni")
                bln1 = 6;
            else if (bln.Text == "Juli")
                bln1 = 7;
            else if (bln.Text == "Agustus")
                bln1 = 8;
            else if (bln.Text == "September")
                bln1 = 9;
            else if (bln.Text == "Oktober")
                bln1 = 10;
            else if (bln.Text == "November")
                bln1 = 11;
            else if (bln.Text == "Desember")
                bln1 = 12;
            else
                bln1 = 0;
            DateTime mo = new DateTime(2016, bln1, (int)tgl.Value);
            monthCalendar1.RemoveAnnuallyBoldedDate(mo);
           
        }
    }
}
