using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan5_1
{
    public partial class Form1 : Form
    {
        private bool txtchange;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                jenis.Items.Add(oneFontFamily.Name);
            }

            int[] uk = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int i in uk)
            {
                ukuran.Items.Add(i);
            }

            jenis.Text = this.rtb1.Font.Name.ToString();
            ukuran.Text = this.rtb1.Font.Size.ToString();
        }

        public void berubah()
        {
            float z;
            if (ukuran.Text == "")
            { z = 12; }
            else
            { z = (float)Convert.ToDouble(ukuran.SelectedItem); }

            FontStyle a = (tebal.Checked) ? FontStyle.Bold : FontStyle.Regular;
            a |= (miring.Checked) ? FontStyle.Italic : FontStyle.Regular;
            a |= (garis.Checked) ? FontStyle.Underline : FontStyle.Regular;
            Font baru = new Font(jenis.SelectedItem.ToString(), z, a);
            rtb1.SelectionFont = baru;
            rtb1.SelectionColor = Color.FromName(warna.Text);
            rtb1.Focus();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtchange)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        rtb1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
            }
            else
            {
                ActiveForm.Hide();
                Form1 newform = new Form1();
                newform.ShowDialog();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                rtb1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            txtchange = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtb1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtchange)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        rtb1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if (result == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void Tebal_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectionFont.Bold)
            {
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style ^ FontStyle.Bold);
                tebal.Checked = false;
            }
            else
            {
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style | FontStyle.Bold);
                tebal.Checked = true;
            }
        }

        private void miring_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectionFont.Italic)
            {
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style ^ FontStyle.Italic);
                miring.Checked = false;
            }
            else
            {
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style | FontStyle.Italic);
                miring.Checked = true;
            }
        }

        private void garis_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectionFont.Underline)
            {
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style ^ FontStyle.Underline);
                garis.Checked = false;
            }
            else
            {
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style | FontStyle.Underline);
                garis.Checked = true;
            }
        }

        private void jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            berubah();
        }

        private void ukuran_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            berubah();
        }

        private void warna_Click(object sender, EventArgs e)
        {
            var warna = new ColorDialog();

            if (warna.ShowDialog() == DialogResult.OK)
            {
                rtb1.SelectionColor = warna.Color;
            }
        }

        private void rtb1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.kanan.Show(this, e.X, e.Y);
                if (rtb1.SelectionLength == 0)
                {
                    kanan.Items[0].Enabled = false;
                    kanan.Items[2].Enabled = false;
                }
                else
                {
                    kanan.Items[0].Enabled = true;
                    kanan.Items[2].Enabled = true;
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.SelectedText = "";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.Show();
        }

        public void ubahBackground(string color)
        {
            rtb1.BackColor = Color.FromName(color);
        }
    }
}
