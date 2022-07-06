using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YıldırımBelediyesiTeknikDestekOtomasyonu
{
    public partial class kullaniciGirisi : Form
    {
        public kullaniciGirisi()
        {
            InitializeComponent();
        }

        private void kullaniciGirisi_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Destek Taleplerini Görebilmek için Lütfen şifre giriniz !", "Şifre Girişi Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void giris()
        {
            string sifre = "123456";
            if (txtSifre.Text.ToString() == sifre)
            {
                MessageBox.Show("GİRİŞ BAŞARILI !", "Bilgilendirme");
                ((AnaMenü)Application.OpenForms["AnaMenü"]).Giris();
            }
            else
            {
                MessageBox.Show("HATALI ŞİFRE GİRİŞİ !\n Lütfen Tekrar Deneyin...", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true ;
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                giris();
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
