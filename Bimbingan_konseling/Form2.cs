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
    public partial class F_Konseling : Form
    {
        public F_Konseling()
        {
            InitializeComponent();
        }
     
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if ((id_konseling.Text == "") & (nama_lengkap.Text == "") & (keterangan.Text == "") & (skor.Text == "") & (penangganan.Text == ""))
            {
                MessageBox.Show("Data Konseling Harap Diisi Terlebih Dahulu ");
            }
            else
            {
                SqlDataAdapter sql = new SqlDataAdapter("Select Id_konseling FROM Konseling Where Id_konseling ='" + id_konseling.Text + "'", con);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Id Konseling Telah Digunakan");
                }
                else
                {
                    con.Open();
                    string query = "INSERT INTO Konseling (Id_konseling, NIS, Nama_lengkap, NIP, Id_keterangan, Tgl, Penanganan, Keterangan, Skor) VALUES ('" + id_konseling.Text + "','" + comboBox3.Text + "','" + nama_lengkap.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + dateTimePicker1.Text + "','" + penangganan.Text + "','" + keterangan.Text + "','" + skor.Text + "') ";
                    SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
                    baru1.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Berhasil DiTambahkan");
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void F_Konseling_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Konseling' table. You can move, or remove it, as needed.
            this.konselingTableAdapter.Fill(this.bimbingan_konselingAll.Konseling);
            // TODO: This line of code loads data into the 'bimbingan_konselingDataSetAll.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter1.Fill(this.bimbingan_konselingDataSetAll.Siswa);
            // TODO: This line of code loads data into the 'bimbingan_konselingDataSetAll.Guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter1.Fill(this.bimbingan_konselingDataSetAll.Guru);
            // TODO: This line of code loads data into the 'bimbingan_konselingDataSetAll.Keterangan' table. You can move, or remove it, as needed.
            this.keteranganTableAdapter1.Fill(this.bimbingan_konselingDataSetAll.Keterangan);
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Keterangan' table. You can move, or remove it, as needed.
            //this.keteranganTableAdapter.Fill(this.bimbingan_konselingAll.Keterangan);
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.bimbingan_konselingAll.Siswa);
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter.Fill(this.bimbingan_konselingAll.Guru);

        }

        private void nama_lengkap_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Nama_lengkap from Siswa where NIS = @NIS", con);
            cmd.Parameters.AddWithValue("@NIS", int.Parse(comboBox3.Text));
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                nama_lengkap.Text = da.GetValue(0).ToString();
            }
            con.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Keterangan, Skor from Keterangan where Id_keterangan = @Id_keterangan", con);
            cmd.Parameters.AddWithValue("@Id_keterangan", int.Parse(comboBox4.Text));
            SqlDataReader ada = cmd.ExecuteReader();
            while (ada.Read())
            {
                keterangan.Text = ada.GetValue(0).ToString();
                skor.Text = ada.GetValue(1).ToString();
                
            }
            con.Close();
        }

        private void skor_TextChanged(object sender, EventArgs e)
        {
            int Poin = int.Parse(skor.Text);

            if (Poin <= 10)
            {
                penangganan.Text = "Pemberian Sanksi Berupa Skoring";
            }
            else if ((Poin > 10) & (Poin <= 30))
            {
                penangganan.Text = "Pemberian Saksi Berupa Skor dan Sanksi Fisik";
            }
            else if ((Poin > 30) & (Poin <= 50))
            {
                penangganan.Text = "Pemberian Sanksi Berupa Skor dan Pemantauan Siswa";
            }
            else if ((Poin > 50) & (Poin <= 80))
            {
                penangganan.Text = " Pemberian Sanksi Berupa Skorsing";
            }
            else if ((Poin > 80) & (Poin == 100))
            {
                penangganan.Text = "Mengeluarkan Surat Pangilan Kepada Orang Tua";
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            id_konseling.Text = "";
            nama_lengkap.Text = "";
            keterangan.Text = "";
            skor.Text = "";
            penangganan.Text = "";
        }
    }
}
