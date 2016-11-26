using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const long MOD = 1000000007;

        private void btnhitung_Click(object sender, EventArgs e)
        {
            long a, b, hasil;
            a = Convert.ToInt64(txt1.Text);
            b = Convert.ToInt64(txt2.Text);
            if (a < b)
            {
                long temp = a;
                a = b;
                b = temp;
            }

            if ((a > 25 && a - b != 2) || (a - b < 2) || (a < 25))
            {
                hasil = 0;
            }
            else
            {
                hasil = kombinasi(Math.Min(a + b - 1, 47), Math.Min(a - 1, 24));
                hasil *= powerMod(2, a - 25);
                hasil %= MOD;
            }
            txthasil.Text = hasil.ToString();
        }

        private long kombinasi(long n, long r)
        {
            if (n < r) return 0;
            long hasil = 1;
            hasil *= faktorial(n);
            hasil %= MOD;
            hasil *= InverseEuler(faktorial(n - r));
            hasil %= MOD;
            hasil *= InverseEuler(faktorial(r));
            hasil %= MOD;
            return hasil;
        }

        private long InverseEuler(long n)
        {
            return powerMod(n, MOD - 2);
        }

        private long faktorial(long n)
        {
            long hasil = 1;
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
                hasil %= MOD;
            }
            return hasil;
        }

        private long powerMod(long b, long e)
        {
            long res = 1;
            while (e > 0)
            {
                if (e % 2 == 1)
                {
                    res = (res * b) % MOD;
                }
                b = (b * b) % MOD;
                e /= 2;
            }
            return res % MOD;
        }
    }
}
