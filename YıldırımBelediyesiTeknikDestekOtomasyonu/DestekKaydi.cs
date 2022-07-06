using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace YıldırımBelediyesiTeknikDestekOtomasyonu
{
    public partial class DestekKaydi : Form
    {
        private string id = "";
        public string taleptarihi = DateTime.Now.ToString();
        public string talepsonucu = "Talep Oluşturuldu";
        private void resetle()
        {
            this.id = string.Empty;
            txtAd.Text = "";
            txtSoyad.Text = "";
            comboBoxMüdürlük.Text = "";
            comboBoxDurum.Text = "Belirtilmedi...";
            comboBoxMüdürlük.Text = "Seçiniz...";
        }
        private void execute(string mySQL,string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            CRUD.performCRUD(CRUD.cmd);
        }
        private void addParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("ad", txtAd.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("soyad", txtSoyad.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("müdürlük", comboBoxMüdürlük.SelectedItem.ToString());
            CRUD.cmd.Parameters.AddWithValue("durum", comboBoxDurum.SelectedItem.ToString());
            CRUD.cmd.Parameters.AddWithValue("talep", txtTalep.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("tarih", taleptarihi.Trim());
            CRUD.cmd.Parameters.AddWithValue("sondurum", talepsonucu.Trim());
            if(str=="Update"|| str=="Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }
        public DestekKaydi()
        {
            InitializeComponent();
            resetle();
        }
        private void DestekKaydi_Load(object sender, EventArgs e)
        {
            resetle();
        }
       

        private void btnKayit_Click(object sender, EventArgs e)
        {
          if(string.IsNullOrEmpty(txtAd.Text.Trim()) || string.IsNullOrEmpty(txtSoyad.Text.Trim()))
            {
                MessageBox.Show("Lütfen Adınızı Ve soyadınızı Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CRUD.sql = "INSERT INTO tb_talep(ad,soyad,müdürlük,durum,talep,tarih,sondurum) VALUES(@ad,@soyad,@müdürlük,@durum,@talep,@tarih,@sondurum)";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Talep Kaydınız Başarıyla oluşturuldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadData("");
            resetle();
        }
    }
}
