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
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
        }

        private void Liste_Load(object sender, EventArgs e)
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
    }
}
