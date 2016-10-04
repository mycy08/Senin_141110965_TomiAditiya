using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gnt()
        {
            if (scrol1.Value <= scrol2.Value)
            {
                min.Text = "Min = " + scrol1.Value.ToString();
                max.Text = "Max = " + scrol2.Value.ToString();
                minta.Text = "Min Tahun = " + (2016 - scrol1.Value);
                maxta.Text = "Max Tahun = " + (2016 + scrol2.Value);
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-scrol1.Value);
                dateTimePicker1.MaxDate = DateTime.Today.AddYears(scrol2.Value);
            }
            else {
                min.Text = "Min = " + scrol2.Value.ToString();
                max.Text = "Max = " + scrol1.Value.ToString();
                minta.Text = "Min Tahun = " + (2016 - scrol1.Value);
                maxta.Text = "Max Tahun = " + (2016 + scrol2.Value);
                dateTimePicker1.MinDate = DateTime.Today.AddYears(-scrol2.Value);
                dateTimePicker1.MaxDate = DateTime.Today.AddYears(scrol1.Value);
            }
        }

        private void gnt1(object sender, ScrollEventArgs e)
        {
            sc1.Text = "Scroll 1 = " + scrol1.Value.ToString();
            gnt();
        }
        private void gnt2(object sender, ScrollEventArgs e)
        {
            sc2.Text = "Scroll 2 = " + scrol2.Value.ToString();
            gnt();
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void scrol1_Scroll(object sender, ScrollEventArgs e)
        {
            sc1.Text = "Scroll 1 = " + scrol1.Value.ToString();
            gnt();
        }

        private void scrol2_Scroll(object sender, ScrollEventArgs e)
        {
            sc2.Text = "Scroll 2 = " + scrol2.Value.ToString();
            gnt();
        }

      

      

      

       
    }
}
