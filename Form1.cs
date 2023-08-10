using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double _sayi1;
        private char _islem;
        private bool _temizle;
        public Form1()
        {
            InitializeComponent();
        }
//Buradan itibaren sayıların ekrana yazdırılmasını sağladım.
        private void sayi0_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "0";
        }

        private void sayi1_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "1";
        }

        private void sayi2_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "2";
        }

        private void sayi3_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "3";
        }

        private void sayi4_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "4";
        }

        private void sayi5_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "5";
        }

        private void sayi6_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "6";
        }

        private void sayi7_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "7";
        }

        private void sayi8_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "8";
        }

        private void sayi9_Click(object sender, EventArgs e)
        {
            if (_temizle == true)
            {
                cikti.Text = "";
                _temizle = false;
            }
            if (cikti.Text == "0") { cikti.Text = ""; }
            cikti.Text += "9";
        }
//Buradan itibaren matematik işlemlerini ayarladım.
        private void topla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _temizle = true;
            _sayi1 = Convert.ToDouble(cikti.Text);


        }

        private void cikar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _temizle = true;
            _sayi1 = Convert.ToDouble(cikti.Text);
        }

        private void carp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _temizle = true;
            _sayi1 = Convert.ToDouble(cikti.Text);
        }

        private void bol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _temizle = true;
            _sayi1 = Convert.ToDouble(cikti.Text);
        }

        private void sonuc_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(cikti.Text);
            double result = 0;
            switch (_islem)
            {
                case '+':
                    result = _sayi1 + sayi2;
                    break;
                case '-':
                    result = _sayi1 - sayi2;
                    break;
                case '*':
                    result = _sayi1 * sayi2;
                    break;
                case '/':
                    result = _sayi1 / sayi2;
                    break;

            }
            cikti.Text = Convert.ToString(result);
            _temizle = true;
        }

        private void virgul_Click(object sender, EventArgs e)
        {
            int virgul = cikti.Text.IndexOf(',');
            bool varmi;
            if (virgul != -1) { varmi = true; }
            else
            {
                varmi = false;
            }

            if (varmi == true)
            {
                cikti.Text += "";
            }
            else { cikti.Text += ","; }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            cikti.Text = "0";
        }
//Buradan itibaren sayıların ve matematik operatörlerinin klavye üzerinden de kullanılabilmesini sağladım.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                sayi0_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                sayi1_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                sayi2_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                sayi3_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                sayi4_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                sayi5_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                sayi6_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                sayi7_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                sayi8_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                sayi9_Click(null, null);
            }
            if (e.KeyCode == Keys.Divide)
            {
                bol_Click(null, null);
            }
            if (e.KeyCode == Keys.Subtract)
            {
                cikar_Click(null, null);
            }
            if (e.KeyCode == Keys.Multiply)
            {
                carp_Click(null, null);
            }
            if (e.KeyCode == Keys.Add)
            {
                topla_Click(null, null);
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                virgul_Click(null, null);
            }
        }
    }
}
