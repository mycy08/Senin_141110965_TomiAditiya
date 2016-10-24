namespace Latihan_3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnd = new System.Windows.Forms.ToolStripButton();
            this.tsFont = new System.Windows.Forms.ToolStripComboBox();
            this.tsColor = new System.Windows.Forms.ToolStripComboBox();
            this.editor = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSize,
            this.tsBold,
            this.tsItalic,
            this.tsUnd,
            this.tsFont,
            this.tsColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(437, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSize
            // 
            this.tsSize.Name = "tsSize";
            this.tsSize.Size = new System.Drawing.Size(75, 25);
            this.tsSize.SelectedIndexChanged += new System.EventHandler(this.tsSize_SelectedIndexChanged);
            // 
            // tsBold
            // 
            this.tsBold.CheckOnClick = true;
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = ((System.Drawing.Image)(resources.GetObject("tsBold.Image")));
            this.tsBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(23, 22);
            this.tsBold.Text = "Bold";
            this.tsBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // tsItalic
            // 
            this.tsItalic.CheckOnClick = true;
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsItalic.Image")));
            this.tsItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(23, 22);
            this.tsItalic.Text = "Italic";
            this.tsItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsUnd
            // 
            this.tsUnd.CheckOnClick = true;
            this.tsUnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnd.Image = ((System.Drawing.Image)(resources.GetObject("tsUnd.Image")));
            this.tsUnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnd.Name = "tsUnd";
            this.tsUnd.Size = new System.Drawing.Size(23, 22);
            this.tsUnd.Text = "Underline";
            this.tsUnd.Click += new System.EventHandler(this.tsUnd_Click);
            // 
            // tsFont
            // 
            this.tsFont.Name = "tsFont";
            this.tsFont.Size = new System.Drawing.Size(121, 25);
            this.tsFont.SelectedIndexChanged += new System.EventHandler(this.tsFont_SelectedIndexChanged);
            // 
            // tsColor
            // 
            this.tsColor.Name = "tsColor";
            this.tsColor.Size = new System.Drawing.Size(121, 25);
            // 
            // editor
            // 
            this.editor.Location = new System.Drawing.Point(0, 28);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(437, 241);
            this.editor.TabIndex = 1;
            this.editor.Text = "";
            this.editor.SelectionChanged += new System.EventHandler(this.editor_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Tom++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tsSize;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnd;
        private System.Windows.Forms.ToolStripComboBox tsFont;
        private System.Windows.Forms.ToolStripComboBox tsColor;
        private System.Windows.Forms.RichTextBox editor;
    }
}

