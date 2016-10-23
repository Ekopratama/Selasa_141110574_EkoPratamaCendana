using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan2_1
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dmonth = new Dictionary<string, int>();
        string smonth = "";
        DateTime date;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date = new DateTime(DateTime.Now.Year, 1, DateTime.Now.Day);
            for (int i = 1; i <= 12; i++)
            {
                smonth = date.ToString("MMMM");
                Bulan.Items.Add(smonth);
                dmonth.Add(smonth, i);
                date = date.AddMonths(1);
            }
            for (DateTime i = new DateTime(2016, 1, 1); i.Year <= 2017; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    Kalender.AddBoldedDate(i);
                }
            }
            Kalender.AddAnnuallyBoldedDate(new DateTime(2016, 12, 28));
            Kalender.UpdateBoldedDates();
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            BoldDateRange("Tambah");
            if (Bulan.Text != "Month")
            {
                Kalender.AddAnnuallyBoldedDate(
                    new DateTime(DateTime.Now.Year, dmonth[Bulan.Text], Convert.ToInt32(Tanggal.Value)));
                Kalender.UpdateBoldedDates();
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            BoldDateRange("Hapus");
            if (Bulan.Text != "Month")
            {
                Kalender.RemoveAnnuallyBoldedDate(
                    new DateTime(DateTime.Now.Year, dmonth[Bulan.Text], Convert.ToInt32(Tanggal.Value)));
                Kalender.UpdateBoldedDates();
            }
        }

        private void BoldDateRange(string action)
        {
            for (DateTime i = Kalender.SelectionStart.Date; i <= Kalender.SelectionEnd.Date; i = i.AddDays(1))
            {
                if (action == "Tambah")
                {
                    Kalender.AddBoldedDate(i);
                }
                else if (action == "Hapus")
                {
                    Kalender.RemoveBoldedDate(i);
                }
            }
            Kalender.UpdateBoldedDates(); action = "";
        }
    }
}
