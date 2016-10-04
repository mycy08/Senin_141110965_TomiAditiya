namespace Latihan_1_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maxta = new System.Windows.Forms.Label();
            this.minta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.max = new System.Windows.Forms.Label();
            this.sc2 = new System.Windows.Forms.Label();
            this.scrol2 = new System.Windows.Forms.HScrollBar();
            this.sc1 = new System.Windows.Forms.Label();
            this.nmin = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.scrol1 = new System.Windows.Forms.HScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(475, 279);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maxta);
            this.tabPage1.Controls.Add(this.minta);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.max);
            this.tabPage1.Controls.Add(this.sc2);
            this.tabPage1.Controls.Add(this.scrol2);
            this.tabPage1.Controls.Add(this.sc1);
            this.tabPage1.Controls.Add(this.nmin);
            this.tabPage1.Controls.Add(this.min);
            this.tabPage1.Controls.Add(this.scrol1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(467, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab Tugas 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // maxta
            // 
            this.maxta.AutoSize = true;
            this.maxta.Location = new System.Drawing.Point(162, 135);
            this.maxta.Name = "maxta";
            this.maxta.Size = new System.Drawing.Size(94, 13);
            this.maxta.TabIndex = 10;
            this.maxta.Text = "Min Tahun = 2016";
            // 
            // minta
            // 
            this.minta.AutoSize = true;
            this.minta.Location = new System.Drawing.Point(20, 135);
            this.minta.Name = "minta";
            this.minta.Size = new System.Drawing.Size(94, 13);
            this.minta.TabIndex = 9;
            this.minta.Text = "Min Tahun = 2016";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(162, 93);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(45, 13);
            this.max.TabIndex = 6;
            this.max.Text = "Max = 0";
            // 
            // sc2
            // 
            this.sc2.AutoSize = true;
            this.sc2.Location = new System.Drawing.Point(11, 44);
            this.sc2.Name = "sc2";
            this.sc2.Size = new System.Drawing.Size(60, 13);
            this.sc2.TabIndex = 5;
            this.sc2.Text = "Scroll 2 = 0";
            // 
            // scrol2
            // 
            this.scrol2.LargeChange = 1;
            this.scrol2.Location = new System.Drawing.Point(7, 62);
            this.scrol2.Maximum = 20;
            this.scrol2.Minimum = 1;
            this.scrol2.Name = "scrol2";
            this.scrol2.Size = new System.Drawing.Size(269, 14);
            this.scrol2.TabIndex = 4;
            this.scrol2.Value = 1;
            this.scrol2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrol2_Scroll);
            // 
            // sc1
            // 
            this.sc1.AutoSize = true;
            this.sc1.Location = new System.Drawing.Point(11, 4);
            this.sc1.Name = "sc1";
            this.sc1.Size = new System.Drawing.Size(60, 13);
            this.sc1.TabIndex = 0;
            this.sc1.Text = "Scroll 1 = 0";
            // 
            // nmin
            // 
            this.nmin.AutoSize = true;
            this.nmin.Location = new System.Drawing.Point(94, 106);
            this.nmin.Name = "nmin";
            this.nmin.Size = new System.Drawing.Size(0, 13);
            this.nmin.TabIndex = 2;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(72, 93);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(42, 13);
            this.min.TabIndex = 1;
            this.min.Text = "Min = 0";
            // 
            // scrol1
            // 
            this.scrol1.LargeChange = 1;
            this.scrol1.Location = new System.Drawing.Point(7, 22);
            this.scrol1.Maximum = 20;
            this.scrol1.Minimum = 1;
            this.scrol1.Name = "scrol1";
            this.scrol1.Size = new System.Drawing.Size(269, 14);
            this.scrol1.TabIndex = 3;
            this.scrol1.Value = 1;
            this.scrol1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrol1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tab Tugas 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "16x16.png");
            this.imageList1.Images.SetKeyName(1, "96x96.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 273);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Latihan_1_1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label maxta;
        private System.Windows.Forms.Label minta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label sc2;
        private System.Windows.Forms.HScrollBar scrol2;
        private System.Windows.Forms.Label sc1;
        private System.Windows.Forms.Label nmin;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.HScrollBar scrol1;
    }
}

