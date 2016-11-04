using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool simp = true;
        public string filelocation = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection ftFamily = new InstalledFontCollection();
            foreach (FontFamily i in ftFamily.Families)
            {
                tsFont.Items.Add(i.Name);
            }
            tsFont.SelectedIndex = 12;
            for (int i = 5; i <= 72; i++)
            {
                tsSize.Items.Add(i);
            }
            tsSize.SelectedIndex = 12;
            tsFont.ComboBox.LostFocus += new EventHandler(tsFont_LostFocus);
            tsSize.ComboBox.LostFocus += new EventHandler(tsFont_LostFocus);
            tsFont.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            tsFont.ComboBox.DrawItem += new DrawItemEventHandler(tsFont_DrawItem);

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                    tsColor.Items.Add(property.Name);
                    tsBC.Items.Add(property.Name);
            }
            tsColor.SelectedIndex = 8;
            tsColor.ComboBox.LostFocus += new EventHandler(tsColor_LostFocus);
            tsColor.ComboBox.DrawItem += new DrawItemEventHandler(tsColor_DrawItem);
            tsColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            tsBC.Text = "White";
            editor.SelectionBackColor = Color.FromName(tsBC.Text);
            tsBC.ComboBox.LostFocus += new EventHandler(tsBC_LostFocus);
            tsBC.ComboBox.DrawItem += new DrawItemEventHandler(tsColor_DrawItem);
            tsBC.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            change();

        }
        public string getBackgroundColor()
        {
            return editor.BackColor.Name;
        }

        public void setBackgroundColor(string color)
        {
            editor.BackColor = Color.FromName(color);
            editor.SelectionBackColor = editor.BackColor;
        }
        private void tsFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(tsFont.Items[e.Index].ToString(), new Font(tsFont.Items[e.Index].ToString(), tsFont.Font.Size), Brushes.Black, e.Bounds);

        }
        private void tsColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics grap = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush fbrush = new SolidBrush(e.ForeColor);
                grap.FillRectangle(brush, e.Bounds);
                string s = (string)this.tsColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                fbrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void tsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox ts = (ToolStripComboBox)sender;
            if (!ts.Focused)
                return;
            change();
        }
        private void tsColor_LostFocus(object sender, EventArgs e)
        {
            int length = editor.SelectionLength;
            int start = editor.SelectionStart;
            editor.SelectionColor = Color.FromName(tsColor.Text);
            editor.Select(start, length);
        }

        private void tsBC_LostFocus(object sender, EventArgs e)
        {
            int length = editor.SelectionLength;
            int start = editor.SelectionStart;
            editor.SelectionBackColor = Color.FromName(tsBC.Text);
            editor.Select(start, length);
        }
        public void change()
        {
            bool Bold, Italic, Underline;
            int panjang = editor.SelectionLength;
            int start = editor.SelectionStart;
            float fontSize;
            string fontFamily;
          
            this.editor.SelectionChanged -= new System.EventHandler(this.editor_SelectionChanged);
            if (panjang == 0)
            {
                fontFamily = (tsFont.Text == "") ? editor.SelectionFont.FontFamily.Name : tsFont.Text;
                fontSize = (tsSize.Text == "") ? editor.SelectionFont.Size : Convert.ToSingle(tsSize.Text);
                FontStyle style = (tsBold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (tsItalic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (tsUnd.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font baru = new Font(fontFamily, fontSize, style);
                editor.SelectionFont = baru;
            }
            for (int i = start; i < start + panjang; i++)
            {
                editor.SelectionChanged -= new System.EventHandler(this.editor_SelectionChanged);
                editor.Select(i, 1);
                fontFamily = (tsFont.Text == "") ? editor.SelectionFont.FontFamily.Name : tsFont.Text;
                fontSize = (tsSize.Text == "") ? editor.SelectionFont.Size : Convert.ToSingle(tsSize.Text);

                Bold = editor.SelectionFont.Bold;
                Italic = editor.SelectionFont.Italic;
                Underline = editor.SelectionFont.Underline;

                FontStyle style = (tsBold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (tsItalic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (tsUnd.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font baru = new Font(fontFamily, fontSize, style);
                editor.SelectionFont = baru;
            }

            editor.Select(start, panjang);
            editor.Focus();

            this.editor.SelectionChanged += new System.EventHandler(this.editor_SelectionChanged);

        }

        private void tsSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox ts = (ToolStripComboBox)sender;
            if (!ts.Focused)
                return;
            change();
        }
        

        private void tsBold_Click(object sender, EventArgs e)
        {
            change();
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            change();
        }

        private void tsUnd_Click(object sender, EventArgs e)
        {
            change();
        }

        private void editor_SelectionChanged(object sender, EventArgs e)
        {
            tsBold.Checked = false;
            tsItalic.Checked = false;
            tsUnd.Checked = false;

            if (editor.SelectionFont != null)
            {
                try
                {
                    tsFont.SelectedItem = editor.SelectionFont.FontFamily.Name;
                }
                catch
                {
                    tsFont.Text = "";
                }

                
                tsSize.Text = editor.SelectionFont.Size.ToString();
                

                if (editor.SelectionFont.Style.ToString().IndexOf("Bold") != -1)
                    tsBold.Checked = true;

                if (editor.SelectionFont.Style.ToString().IndexOf("Italic") != -1)
                    tsItalic.Checked = true;

                if (editor.SelectionFont.Style.ToString().IndexOf("Underline") != -1)
                    tsUnd.Checked = true;
            }
            else
            {
                tsSize.Text = "";
                tsFont.Text = "";
            }

            if (editor.SelectionColor.Name == "0")
            {
                tsColor.Text = "Black";
            }
            else
            {
                tsColor.Text = editor.SelectionColor.Name;
            }
                tsBC.Text = editor.BackColor.Name;
        }
        private void tsFont_LostFocus(object sender, EventArgs e)
        {
            change();
        }
        private void save()
        {
            DialogResult fileLoc;
            if (filelocation == "")
            {
                svDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                fileLoc = svDialog.ShowDialog();
                if (fileLoc == DialogResult.OK)
                {
                    editor.SaveFile(svDialog.FileName);
                    filelocation = svDialog.FileName;
                }
            }
            else
            {
                editor.SaveFile(filelocation);
            }
            simp = true;
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void mnSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult fileLoc;

            svDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
            fileLoc = svDialog.ShowDialog();
            if (fileLoc == DialogResult.OK)
            {
                editor.SaveFile(svDialog.FileName);
                filelocation = svDialog.FileName;
            }

            simp = true;
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult fileLoc;
                if (!simp)
                {
                    fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (fileLoc == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (fileLoc == DialogResult.Yes)
                    {
                        save();
                    }
                }
                fileLoc = opDialog.ShowDialog();
                if (fileLoc == DialogResult.OK)
                {
                    filelocation = opDialog.FileName;
                    simp = true;
                    editor.LoadFile(opDialog.FileName);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
            simp = false;
        }

        private void mnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult fileLoc;
                if (!simp)
                {
                    fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (fileLoc == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (fileLoc == DialogResult.Yes)
                    {
                        save();
                    }
                }

                editor.Clear();
                filelocation = "";
                simp = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void exit()
        {
            if (!simp)
            {
                DialogResult fileLoc;
                fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNo);
                if (fileLoc == DialogResult.No)
                {
                    Application.ExitThread();
                }
                else if (fileLoc == DialogResult.Yes)
                {
                    save();
                    Application.ExitThread();
                }
            }
            else
                Application.ExitThread();
        }
        private void tsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = editor.SelectionLength;
            int start = editor.SelectionStart;
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            editor.SelectionColor = Color.FromName(tsColor.Text);
            editor.Focus();
            editor.Select(start, length);
        }

        private void tsBC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = editor.SelectionLength;
            int start = editor.SelectionStart;
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            editor.SelectionBackColor = Color.FromName(tsBC.Text);
            editor.Focus();
            editor.Select(start, length);
        }

        
        private void mnExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                editor.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editor.SelectionLength == 0)
            {
                return;
            }

            editor.SelectedText = "";
        }
        
        private void mnSetting_Click(object sender, EventArgs e)
        {
            
        }
       
        
       
        public void showRTB()
        {
            editor.BringToFront();
            editor.Focus();
        }

        private void editor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (editor.SelectionLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = true;
                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
       
        Setting set;
        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (set == null || !set.IsHandleCreated)
            {
                set = new Setting();
                
                set.MdiParent = this;
                set.BringToFront();
                editor.SendToBack();
                set.Show();
            }
            else
            {
                set.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit();
        }
    }
}
