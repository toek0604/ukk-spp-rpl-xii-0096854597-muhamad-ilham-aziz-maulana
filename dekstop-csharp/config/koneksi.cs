using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;

namespace dekstop_csharp.koneksi.cs
{
    internal class koneksi
    {
        string Koneksi = "server=localhost;port3306;username=root;password=;database=db_spp_xii";
        public static MySqlConnection GetConnection(string connectionString)
        {
            try
            {
                if(string.IsNullOrEmpty(koneksi)) { return null; }
            }
            catch(Exception)
            {
                MessageBox.Show("maaf login anda bermasalah, silahkan coba lagi nanti");
            }
        }
    }
}
