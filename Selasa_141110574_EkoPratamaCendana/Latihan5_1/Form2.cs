using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan5_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.warnaback.Items.Add(c.Name);
                this.warnatext.Items.Add(c.Name);
            }
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tree.ExpandAll();

            if (tree.SelectedNode.Text == "Background (Cover)")
            {
                label1.Visible = true;
                warnaback.Visible = true;

                label2.Visible = false;
                warnatext.Visible = false;

                button1.Visible = true;
            }
            else if (tree.SelectedNode.Text == "Background (Text)")
            {
                label1.Visible = false;
                warnaback.Visible = false;

                label2.Visible = true;
                warnatext.Visible = true;

                button1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                warnatext.Visible = false;

                label2.Visible = false;
                warnaback.Visible = false;

                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)MdiParent;
            main.ubahBackground(warnatext.Text);
        }

        private void warnaback_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Bottom);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void warnatext_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Bottom);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void warnaback_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void warnatext_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
