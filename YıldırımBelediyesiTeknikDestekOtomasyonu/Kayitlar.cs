using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace YıldırımBelediyesiTeknikDestekOtomasyonu
{
    public partial class Kayitlar : Form
    {
        private string id = "";
        private int introw = 0;
        public Kayitlar()
        {
            InitializeComponent();
        }

        private void Kayitlar_Load(object sender, EventArgs e)
        {
            loadData("");
        }
        private void loadData(string keyword)
        {
            CRUD.sql = "SELECT * FROM public.\"tb_talep\"";

            string strKeyword = string.Format("%{0}%", keyword);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("keyword", strKeyword);

            DataTable dt = CRUD.performCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                introw = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                introw = 0;
            }

            DataGridView dg1 = dataGridView1;
            dg1.MultiSelect = false;
            dg1.AutoGenerateColumns = true;
            dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dg1.DataSource = dt;
            dg1.Columns[0].HeaderText = "Talep ID";
            dg1.Columns[1].HeaderText = "Ad";
            dg1.Columns[2].HeaderText = "Soyad";
            dg1.Columns[3].HeaderText = "Müdürlük";
            dg1.Columns[4].HeaderText = "Durum";
            dg1.Columns[5].HeaderText = "Talep";
            dg1.Columns[6].HeaderText = "Talep Oluşturulma Tarihi";
            dg1.Columns[7].HeaderText = "Talebin Son Durumu";

            dg1.Columns[0].Width = 85;
            dg1.Columns[1].Width = 200;
            dg1.Columns[2].Width = 200;
            dg1.Columns[3].Width = 220;
            dg1.Columns[4].Width = 85;
            dg1.Columns[5].Width = 300;
            dg1.Columns[6].Width = 180;
            dg1.Columns[7].Width = 333;


        }

        string ad, soyad, müdürlük, durum, talep, tarih;

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("lütfen listeden Bir kayıt seç");
                return;
            }

            if (MessageBox.Show("Seçili olan Talep kaydını silmek istediğinize emin misiniz?", "Uyarı !",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM tb_talep WHERE autoid=@id::integer";

                execute(CRUD.sql, "Update");

                MessageBox.Show("Silme işlemi başarılı", "Bilgilendirme");

                loadData("");
                txtSondurum.Clear();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;

                this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                btnGüncelle.Text = "Güncelle ( " + this.id + " )";
                btnSil.Text = "Sil ( " + this.id + " )";

                ad= Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                soyad= Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                müdürlük= Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                durum= Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                talep= Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                tarih= Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                txtSondurum.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("lütfen listeden kayıt seç");
                return;
            }
            
            CRUD.sql = "UPDATE tb_talep SET ad=@ad,soyad=@soyad,müdürlük=@müdürlük,durum=@durum,talep=@talep,tarih=@tarih,sondurum=@sondurum WHERE autoid=@id::integer";

            execute(CRUD.sql, "Update");

            MessageBox.Show("Güncelleme başarılı", "oldu");

            loadData("");
            txtSondurum.Clear();
        }
        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            CRUD.performCRUD(CRUD.cmd);
        }
        private void addParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("ad", ad.Trim());
            CRUD.cmd.Parameters.AddWithValue("soyad", soyad.Trim());
            CRUD.cmd.Parameters.AddWithValue("müdürlük", müdürlük.Trim());
            CRUD.cmd.Parameters.AddWithValue("durum", durum.Trim());
            CRUD.cmd.Parameters.AddWithValue("talep", talep.Trim());
            CRUD.cmd.Parameters.AddWithValue("tarih", tarih.Trim());
            CRUD.cmd.Parameters.AddWithValue("sondurum", txtSondurum.Text.Trim());
            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }
    }
}
