namespace LatihanPos
{
    partial class menuBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtubah = new MetroFramework.Controls.MetroTile();
            this.mthapus = new MetroFramework.Controls.MetroTile();
            this.mttambah = new MetroFramework.Controls.MetroTile();
            this.mlrefresh = new MetroFramework.Controls.MetroTile();
            this.mlback = new MetroFramework.Controls.MetroLink();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtubah
            // 
            this.mtubah.ActiveControl = null;
            this.mtubah.Location = new System.Drawing.Point(185, 72);
            this.mtubah.Name = "mtubah";
            this.mtubah.Size = new System.Drawing.Size(75, 54);
            this.mtubah.TabIndex = 1;
            this.mtubah.Text = "Ubah";
            this.mtubah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtubah.UseSelectable = true;
            // 
            // mthapus
            // 
            this.mthapus.ActiveControl = null;
            this.mthapus.Location = new System.Drawing.Point(266, 72);
            this.mthapus.Name = "mthapus";
            this.mthapus.Size = new System.Drawing.Size(75, 54);
            this.mthapus.TabIndex = 1;
            this.mthapus.Text = "Hapus";
            this.mthapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mthapus.UseSelectable = true;
            this.mthapus.Click += new System.EventHandler(this.mthapus_Click);
            // 
            // mttambah
            // 
            this.mttambah.ActiveControl = null;
            this.mttambah.Location = new System.Drawing.Point(104, 72);
            this.mttambah.Name = "mttambah";
            this.mttambah.Size = new System.Drawing.Size(75, 54);
            this.mttambah.TabIndex = 1;
            this.mttambah.Text = "Tambah";
            this.mttambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mttambah.UseSelectable = true;
            this.mttambah.Click += new System.EventHandler(this.mttambah_Click);
            // 
            // mlrefresh
            // 
            this.mlrefresh.ActiveControl = null;
            this.mlrefresh.Location = new System.Drawing.Point(23, 72);
            this.mlrefresh.Name = "mlrefresh";
            this.mlrefresh.Size = new System.Drawing.Size(75, 54);
            this.mlrefresh.TabIndex = 1;
            this.mlrefresh.Text = "Refresh";
            this.mlrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlrefresh.UseSelectable = true;
            this.mlrefresh.UseTileImage = true;
            this.mlrefresh.Click += new System.EventHandler(this.mlrefresh_Click);
            // 
            // mlback
            // 
            this.mlback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlback.Image = global::LatihanPos.Properties.Resources._1481676046_circle_back_arrow_glyph;
            this.mlback.ImageSize = 32;
            this.mlback.Location = new System.Drawing.Point(10, 15);
            this.mlback.Name = "mlback";
            this.mlback.Size = new System.Drawing.Size(48, 42);
            this.mlback.TabIndex = 0;
            this.mlback.UseSelectable = true;
            this.mlback.Click += new System.EventHandler(this.mlback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 230);
            this.dataGridView1.TabIndex = 2;
            // 
            // menuBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mthapus);
            this.Controls.Add(this.mtubah);
            this.Controls.Add(this.mttambah);
            this.Controls.Add(this.mlrefresh);
            this.Controls.Add(this.mlback);
            this.Name = "menuBarang";
            this.Text = "     Barang";
            this.Load += new System.EventHandler(this.menuBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlback;
        private MetroFramework.Controls.MetroTile mlrefresh;
        private MetroFramework.Controls.MetroTile mttambah;
        private MetroFramework.Controls.MetroTile mtubah;
        private MetroFramework.Controls.MetroTile mthapus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}