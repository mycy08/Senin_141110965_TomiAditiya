﻿namespace LatihanPos
{
    partial class menuSuplier
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mthapus = new MetroFramework.Controls.MetroTile();
            this.mtubah = new MetroFramework.Controls.MetroTile();
            this.mttambah = new MetroFramework.Controls.MetroTile();
            this.mlrefresh = new MetroFramework.Controls.MetroTile();
            this.cari = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mlback = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 230);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mthapus
            // 
            this.mthapus.ActiveControl = null;
            this.mthapus.Location = new System.Drawing.Point(266, 75);
            this.mthapus.Name = "mthapus";
            this.mthapus.Size = new System.Drawing.Size(75, 54);
            this.mthapus.TabIndex = 4;
            this.mthapus.Text = "Hapus";
            this.mthapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mthapus.UseSelectable = true;
            this.mthapus.Click += new System.EventHandler(this.mthapus_Click);
            // 
            // mtubah
            // 
            this.mtubah.ActiveControl = null;
            this.mtubah.Location = new System.Drawing.Point(185, 75);
            this.mtubah.Name = "mtubah";
            this.mtubah.Size = new System.Drawing.Size(75, 54);
            this.mtubah.TabIndex = 5;
            this.mtubah.Text = "Ubah";
            this.mtubah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtubah.UseSelectable = true;
            this.mtubah.Click += new System.EventHandler(this.mtubah_Click);
            // 
            // mttambah
            // 
            this.mttambah.ActiveControl = null;
            this.mttambah.Location = new System.Drawing.Point(104, 75);
            this.mttambah.Name = "mttambah";
            this.mttambah.Size = new System.Drawing.Size(75, 54);
            this.mttambah.TabIndex = 6;
            this.mttambah.Text = "Tambah";
            this.mttambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mttambah.UseSelectable = true;
            this.mttambah.Click += new System.EventHandler(this.mttambah_Click);
            // 
            // mlrefresh
            // 
            this.mlrefresh.ActiveControl = null;
            this.mlrefresh.Location = new System.Drawing.Point(23, 75);
            this.mlrefresh.Name = "mlrefresh";
            this.mlrefresh.Size = new System.Drawing.Size(75, 54);
            this.mlrefresh.TabIndex = 7;
            this.mlrefresh.Text = "Refresh";
            this.mlrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlrefresh.UseSelectable = true;
            this.mlrefresh.UseTileImage = true;
            this.mlrefresh.Click += new System.EventHandler(this.mlrefresh_Click);
            // 
            // cari
            // 
            // 
            // 
            // 
            this.cari.CustomButton.Image = null;
            this.cari.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.cari.CustomButton.Name = "";
            this.cari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cari.CustomButton.TabIndex = 1;
            this.cari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cari.CustomButton.UseSelectable = true;
            this.cari.CustomButton.Visible = false;
            this.cari.Lines = new string[0];
            this.cari.Location = new System.Drawing.Point(503, 97);
            this.cari.MaxLength = 32767;
            this.cari.Name = "cari";
            this.cari.PasswordChar = '\0';
            this.cari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cari.SelectedText = "";
            this.cari.SelectionLength = 0;
            this.cari.SelectionStart = 0;
            this.cari.ShortcutsEnabled = true;
            this.cari.Size = new System.Drawing.Size(119, 23);
            this.cari.TabIndex = 10;
            this.cari.UseSelectable = true;
            this.cari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(492, 87);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(144, 42);
            this.metroTile2.TabIndex = 9;
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink1.Image = global::LatihanPos.Properties.Resources._1482448658_circle_edit_search_thin;
            this.metroLink1.ImageSize = 64;
            this.metroLink1.Location = new System.Drawing.Point(445, 87);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(48, 42);
            this.metroLink1.TabIndex = 11;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // mlback
            // 
            this.mlback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlback.Image = global::LatihanPos.Properties.Resources._1481676046_circle_back_arrow_glyph;
            this.mlback.ImageSize = 32;
            this.mlback.Location = new System.Drawing.Point(13, 16);
            this.mlback.Name = "mlback";
            this.mlback.Size = new System.Drawing.Size(48, 42);
            this.mlback.TabIndex = 3;
            this.mlback.UseSelectable = true;
            this.mlback.Click += new System.EventHandler(this.mlback_Click);
            // 
            // menuSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 386);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mthapus);
            this.Controls.Add(this.mtubah);
            this.Controls.Add(this.mttambah);
            this.Controls.Add(this.mlrefresh);
            this.Controls.Add(this.mlback);
            this.Name = "menuSuplier";
            this.Text = "     Supplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuSuplier_FormClosed);
            this.Load += new System.EventHandler(this.menuSuplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile mthapus;
        private MetroFramework.Controls.MetroTile mtubah;
        private MetroFramework.Controls.MetroTile mttambah;
        private MetroFramework.Controls.MetroTile mlrefresh;
        private MetroFramework.Controls.MetroLink mlback;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox cari;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}