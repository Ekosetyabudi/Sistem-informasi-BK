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
    public partial class registrasi : Form
    {
        public registrasi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            F_Login panggil = new F_Login();
            panggil.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Guru (NIP, Nama_guru, EmailTlp) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"') ";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Dikirim Mohon Segera Melaporkan Admin Untuk Mengetahui Kata Sandi");
        }
    }
}
