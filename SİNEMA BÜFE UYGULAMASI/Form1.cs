using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMA_BÜFE_UYGULAMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double su, bcips, kcips, misir, cikolata, kola, toplam, ciro;
        double susatis, bcipssatis, kcipssatis, misirsatis, cikosatis, kolasatis;

       

        private void btnmisirarti_Click(object sender, EventArgs e)
        {
            misir++;
            txtMisir.Text = misir.ToString();
        }

        private void btncikolataarti_Click(object sender, EventArgs e)
        {
            cikolata++;
            txtCikolata.Text = cikolata.ToString();
        }

        private void btnsueksi_Click(object sender, EventArgs e)
        {
            if(su > 0)
            {
                su--;
                txtSu.Text = su.ToString();
            }
        }

        private void btnkolaeksi_Click(object sender, EventArgs e)
        {
            if(kola > 0)
            {
                txtKola.Text = kola.ToString();
            }
        }

        private void btnbcipseksi_Click(object sender, EventArgs e)
        {
            if(bcips > 0)
            {
                kcips--;
                txtBcips.Text = bcips.ToString();
            }
        }

        private void btnkcipseksi_Click(object sender, EventArgs e)
        {
            if(kcips > 0)
            {
                kcips--;
                txtKcips.Text = kcips.ToString();
            }
        }

        private void btnmisireksi_Click(object sender, EventArgs e)
        {
            if(misir > 0)
            {
                misir--;
                txtMisir.Text = misir.ToString();
            }
        }

        private void txtSu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtKola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBcips_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtKcips_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMisir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCikolata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSu.Enabled = false;
            txtKola.Enabled = false;
            txtBcips.Enabled = false;
            txtKcips.Enabled = false;
            txtCikolata.Enabled = false;
            txtMisir.Enabled = false;
            button1.Enabled = false;

            btnHesap.Enabled = true;
            btnhspduzen.Enabled = false;
            btnNew.Enabled = false;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GunSonu gun = new GunSonu();
            gun.gunsonuciro.Text = ciro.ToString() + " Adet";
            gun.lblsusatis.Text = susatis.ToString() + " Adet";
            gun.lblkolasatis.Text = kolasatis.ToString() + " Adet";
            gun.lblbcipssatis.Text = bcipssatis.ToString() + " Adet";
            gun.lblkcipssatis.Text = kcipssatis.ToString() + " Adet";
            gun.lblmisirsatis.Text = misirsatis.ToString() + " Adet";
            gun.lblcikolatasatis.Text = cikosatis.ToString() + " Adet";
            gun.Show();


            txtSu.Enabled = false;
            txtKola.Enabled = false;
            txtKcips.Enabled = false;
            txtBcips.Enabled = false;
            txtMisir.Enabled = false;
            txtCikolata.Enabled = false;

            button1.Enabled = false;
            btnHesap.Enabled = false;
            btnhspduzen.Enabled = false;
            btnNew.Enabled = false;

            btnSuarttır.Enabled = false;
            btnkolaarti.Enabled = false;
            btnbcipsarti.Enabled = false;
            btnkcipsarti.Enabled = false;
            btnmisirarti.Enabled = false;
            btncikolataarti.Enabled = false;

            btnsueksi.Enabled = false;
            btnkolaeksi.Enabled = false;
            btnbcipseksi.Enabled = false;
            btnkcipseksi.Enabled = false;
            btnmisireksi.Enabled = false;
            btncikoeksi.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ciro += toplam;
            

            su = 0;
            kola = 0;
            bcips = 0;
            kcips = 0;
            cikolata = 0;
            misir = 0;
            toplam = 0;

            txtSu.Text = "0";
            txtKola.Text = "0";
            txtBcips.Text = "0";
            txtKcips.Text = "0";
            txtCikolata.Text = "0";
            txtMisir.Text = "0";

            lblToplam.Text = "0";

            txtSu.Focus();

            btnHesap.Enabled = true;
            btnNew.Enabled = false;
            btnhspduzen.Enabled = false;
            button1.Enabled = true;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            
            su = Convert.ToInt32(txtSu.Text);
            kola = Convert.ToInt32(txtKola.Text);
            bcips = Convert.ToInt32(txtBcips.Text);
            kcips = Convert.ToInt32(txtKcips.Text);
            misir = Convert.ToInt32(txtMisir.Text);
            cikolata = Convert.ToInt32(txtCikolata.Text);

            susatis += su;
            kolasatis += kola;
            bcipssatis += bcips;
            kcipssatis += kcips;
            misirsatis += misir;
            cikosatis += cikolata;

            if (su > 0 || kola > 0 || bcips > 0 || kcips > 0 || misir > 0 || cikolata > 0)
            {
                toplam = su * 2.50 + kola * 5 + bcips * 8 + kcips * 6 + misir * 15 + cikolata * 4.50;
                lblToplam.Text = toplam.ToString();               

                btnHesap.Enabled = false;
                btnNew.Enabled = true;
                btnhspduzen.Enabled = true;

                txtSu.Enabled = false;
                txtKola.Enabled = false;
                txtKcips.Enabled = false;
                txtBcips.Enabled = false;
                txtMisir.Enabled = false;
                txtCikolata.Enabled = false;
                button1.Enabled = false;
            }

            else
            {
                MessageBox.Show("HESAP ÇIKARTABİLMENİZ İÇİN EN AZ 1 ADET ÜRÜN EKLEMELİSİNİZ!");
            }

            
        }

        private void btncikoeksi_Click(object sender, EventArgs e)
        {
            if (cikolata > 0)
            {
                cikolata--;
                txtCikolata.Text = cikolata.ToString();
            }
        }

        private void btnkcipsarti_Click(object sender, EventArgs e)
        {
            kcips++;
            txtKcips.Text = kcips.ToString();
        }

        private void btnbcipsarti_Click(object sender, EventArgs e)
        {
            bcips++;
            txtBcips.Text = bcips.ToString();
        }

        private void btnkolaarti_Click(object sender, EventArgs e)
        {
            kola++;
            txtKola.Text = kola.ToString();
        }

       
        private void btnSuarttır_Click(object sender, EventArgs e)
        {
            su++;
            txtSu.Text = su.ToString();
        }
    }
}
