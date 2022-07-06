using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YıldırımBelediyesiTeknikDestekOtomasyonu
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            Thread t = new Thread(new ThreadStart(Startform));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void Startform()
        {
          Application.Run(new LoadingScreen());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormAnaMenu.Controls.Add(childForm);
            panelChildFormAnaMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void Giris()
        {
            openChildForm(new Kayitlar());
        }


        private void btnTlpKayit_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DestekKaydi());
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            openChildForm(new kullaniciGirisi());
        }

        private void btnAnaMenu_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AnaSayfa());
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            openChildForm(new Liste());
        }

        private void panelChildFormAnaMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {

        }
    }
}
