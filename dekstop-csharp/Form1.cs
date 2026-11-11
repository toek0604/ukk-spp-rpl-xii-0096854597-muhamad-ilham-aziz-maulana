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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = button1;
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validasi input
            if (string.IsNullOrWhiteSpace(textBox1.Text)) 
            {
                MessageBox.Show("username tidak boleh kosong!","peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text)
            {
                MessageBox.Show("password tdk boleh kosong!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;

            }
            MySqlConnection k = Koneksi.GetKoneksi();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                string query = "SELECT * FROM petugas WHERE username =@username AND @password";
                cmd.Parameters.AddWithValue();
            }
            catch (Exception)
            {

            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
