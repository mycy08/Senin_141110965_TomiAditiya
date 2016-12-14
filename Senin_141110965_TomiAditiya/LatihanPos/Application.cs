using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace LatihanPos
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 2;
            if (rectangleShape2.Width >= 442) {
                timer1.Stop();
                login lgn = new login();
                lgn.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
