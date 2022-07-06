using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Threading.Tasks;

namespace YıldırımBelediyesiTeknikDestekOtomasyonu
{
    class CRUD
    {
        private static string getConnectionString()
        {

            string host = "Host=localhost;";
            string port = "Port=5432;";
            string db = "Database=cs_smart_crud;";
            string user = "Username=yildirimbilgi;";
            string pass = "Password=Bilgi2020.;";

            string conString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);

            return conString;
        }
        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable performCRUD(NpgsqlCommand con)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = con;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;

            }

            return dt;
        }
    }
 
}
