using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bimbingan_konseling
{
    public partial class F_Login : Form
    {
        
        public F_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {

            SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Guru where Nama_guru = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'",koneksi);
            DataTable dt = new DataTable();
            sda.Fill (dt);
           
            
            if (dt.Rows[0][0].ToString() == "1")
            {

                
                Halaman_utama panggil = new Halaman_utama();
                
                if (textBox1.Text != "Admin")
                {
                    panggil.bt_maintenance.Enabled = false;

                }

                panggil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mohon Isi Nama Guru Dan Password Dengan Benar !!! ", "Perhatian!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrasi panggil = new registrasi();
            panggil.Show();
            this.Hide();
        }
    }
}
