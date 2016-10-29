using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void jenis_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(jenis.Items[e.Index].ToString(), new Font(jenis.Items[e.Index].ToString(), jenis.Font.Size), Brushes.Black, e.Bounds);
        }

        private void warna_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush bb = new SolidBrush(e.BackColor);
                Brush bf = new SolidBrush(e.ForeColor);

                g.FillRectangle(bb, e.Bounds);
                string s = (string)this.warna.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                bb.Dispose();
                bf.Dispose();
            }
            e.DrawFocusRectangle();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection arr = new InstalledFontCollection();
            foreach (FontFamily i in arr.Families)
            {
                jenis.Items.Add(i.Name);
            }
            jenis.SelectedIndex = 14;

            for (int i = 5; i <= 72; i++)
                ukuran.Items.Add(i);
            ukuran.SelectedIndex = 7;

            jenis.ComboBox.LostFocus += new EventHandler(jenis_LostFocus);
            ukuran.ComboBox.LostFocus += new EventHandler(jenis_LostFocus);
            jenis.ComboBox.DrawItem += new DrawItemEventHandler(jenis_DrawItem);
            jenis.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                    warna.Items.Add(property.Name);
            }

            warna.SelectedIndex = 8;
            warna.ComboBox.LostFocus += new EventHandler(jenis_LostFocus);
            warna.ComboBox.DrawItem += new DrawItemEventHandler(warna_DrawItem);
            warna.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            berubah();
        }
        public void berubah()
        {
            float z;
            if (ukuran.Text == "")
                z = 12;
            else
                z = (float)Convert.ToDouble(ukuran.SelectedItem);
            //FontStyle a = new FontStyle();
            //if (tebal.Checked)
            //{
            //    a = FontStyle.Bold;
            //    if (miring.Checked)
            //        a = FontStyle.Italic;
            //    else if (garis.Checked)
            //        a = FontStyle.Underline;
            //}
            //else if (miring.Checked)
            //{
            //    a = FontStyle.Italic;
            //    if (tebal.Checked)
            //        a = FontStyle.Bold;
            //    else if (garis.Checked)
            //        a = FontStyle.Underline;
            //}
            //else if (garis.Checked)
            //{
            //    a = FontStyle.Underline;
            //    if (tebal.Checked)
            //        a = FontStyle.Bold;
            //    else if (miring.Checked)
            //        a = FontStyle.Italic;
            //}
            //else
            //    a = FontStyle.Regular;
            FontStyle a = (tebal.Checked) ? FontStyle.Bold : FontStyle.Regular;
            a |= (miring.Checked) ? FontStyle.Italic : FontStyle.Regular;
            a |= (garis.Checked) ? FontStyle.Underline : FontStyle.Regular;
            Font baru = new Font(jenis.SelectedItem.ToString(), z, a);
            rtb1.SelectionFont = baru;
            rtb1.SelectionColor = Color.FromName(warna.Text);
            rtb1.Focus();
        }

        private void jenis_LostFocus(object sender, EventArgs e)
        {
            berubah();
        }

        private void rtb1_SelectionChanged(object sender, EventArgs e)
        {
            if (rtb1.SelectionFont != null)
            {
                try
                {
                    jenis.SelectedItem = rtb1.SelectionFont.FontFamily.Name;
                }
                catch
                {
                    jenis.Text = "";
                }

                try
                {
                    ukuran.SelectedIndex = (int)rtb1.SelectionFont.Size - 5;
                }
                catch { ukuran.Text = ""; }

                try
                {
                    warna.SelectedItem = rtb1.SelectionColor.Name;
                }
                catch
                {
                    warna.Text = "";
                }

                if (rtb1.SelectionFont.Style.ToString().IndexOf("Bold") != -1)
                    tebal.Checked = true;

                if (rtb1.SelectionFont.Style.ToString().IndexOf("Italic") != -1)
                    miring.Checked = true;

                if (rtb1.SelectionFont.Style.ToString().IndexOf("Underline") != -1)
                    garis.Checked = true;
            }
            else
            {
                ukuran.SelectedIndex = 7;
                jenis.SelectedIndex = 14;
            }
        }

        private void ukuran_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            berubah();
        }

        private void tebal_Click(object sender, EventArgs e)
        {
            berubah();
        }

        private void miring_Click(object sender, EventArgs e)
        {
            berubah();
        }

        private void garis_Click(object sender, EventArgs e)
        {
            berubah();
        }

        private void jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            berubah();
        }
    }
}
