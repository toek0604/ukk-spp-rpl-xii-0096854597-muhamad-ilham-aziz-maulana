using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dekstop_csharp
{
    public partial class Formregister : Form
    {
        public Formregister()
        {
            InitializeComponent();
            string koneksi = "server=localhost;port3306;username=root;password=;database=db_spp_xii";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formregister_Load(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            MySqlConnection k = new MySqlConnection(koneksi);
            try
            {
                k.Open();
                string.query = "INSERT INTO petugas (username, password, ama_petugas, level) VALUES(@username, @password, @nama_petugas, @level)";
                MySqlCommand cmd = new MySqlCommand(Query, k);
                cmd.Parameters
            }
        }
    }
}
