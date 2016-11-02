namespace Latihan4_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.svDialog = new System.Windows.Forms.SaveFileDialog();
            this.opDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(457, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSize
            // 
            this.tsSize.Name = "tsSize";
            this.tsSize.Size = new System.Drawing.Size(121, 25);
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
            // 
            // tsColor
            // 
            this.tsColor.Name = "tsColor";
            this.tsColor.Size = new System.Drawing.Size(121, 25);
            // 
            // editor
            // 
            this.editor.Location = new System.Drawing.Point(0, 52);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(457, 242);
            this.editor.TabIndex = 1;
            this.editor.Text = "";
            this.editor.SelectionChanged += new System.EventHandler(this.editor_SelectionChanged);
            this.editor.TextChanged += new System.EventHandler(this.editor_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.mnOpen,
            this.mnSave,
            this.mnSaveAs,
            this.mnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.Size = new System.Drawing.Size(152, 22);
            this.mnNew.Text = "New";
            this.mnNew.Click += new System.EventHandler(this.mnNew_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(152, 22);
            this.mnOpen.Text = "Open";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mnSave
            // 
            this.mnSave.Name = "mnSave";
            this.mnSave.Size = new System.Drawing.Size(152, 22);
            this.mnSave.Text = "Save";
            this.mnSave.Click += new System.EventHandler(this.mnSave_Click);
            // 
            // mnSaveAs
            // 
            this.mnSaveAs.Name = "mnSaveAs";
            this.mnSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnSaveAs.Text = "Save As";
            this.mnSaveAs.Click += new System.EventHandler(this.mnSaveAs_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(152, 22);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // opDialog
            // 
            this.opDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 282);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tom ++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnNew;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
        private System.Windows.Forms.ToolStripMenuItem mnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.SaveFileDialog svDialog;
        private System.Windows.Forms.OpenFileDialog opDialog;
    }
}

