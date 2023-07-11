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
    public partial class histori_konseling : Form
    {
        Class_konseling Konseling = new Class_konseling();
        public histori_konseling()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
                Laporan panggil = new Laporan();
                panggil.Show();
                this.Hide();
                if (edt_penguna.Text == "User")
                {
                    panggil.textBox2.Text = "User";

                }
                else
                {
                    panggil.textBox2.Text = "Admin";
                }
        }

        private void histori_konseling_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Konseling";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            DataTable br1 = new DataTable();
            baru1.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Halaman_utama a = new Halaman_utama();
            if (edt_penguna.Text == "User")
            {
                a.bt_maintenance.Enabled = false;
            }
            else
            {
                a.bt_maintenance.Enabled = true;
            }
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Konseling where NIS = '"+NIS.Text+"'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            DataTable br1 = new DataTable();
            baru1.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();
            if (NIS.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(Skor) from Konseling where NIS = @NIS", con);
                cmd.Parameters.AddWithValue("@NIS", int.Parse(NIS.Text));
            
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox1.Text = da.GetValue(0).ToString();
                }
                con.Close();
            }
            int Total = int.Parse(textBox1.Text);
            if (Total >= 80)
            {
                MessageBox.Show("Total Skor Siswa Ini Telah Melebihi Batas Yang Di Tentukan Harap Dimohon Mengeluarkan Surat Pagilan Orang Tua");

            }
            else if ((Total >= 50) & (Total < 80))
            {
                MessageBox.Show("Total Skor Siswa Ini Telah Melebihi 50 poin Harap Mengeluarkan Surat Skorsing Kepada Siswa");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Konseling where Tgl between  '" + dtDari.Value + "' and '" + dtHingga.Value + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            DataTable br1 = new DataTable();
            baru1.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();
        }
    }
}
