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
    public partial class Maintenance_konseling : Form
    {
        public Maintenance_konseling()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
        private void Maintenance_konseling_Load(object sender, EventArgs e)
        {
            con.Open();
            string query2 = "SELECT * FROM Konseling";
            SqlDataAdapter baru2 = new SqlDataAdapter(query2, con);
            DataTable br1 = new DataTable();
            baru2.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();

            // TODO: This line of code loads data into the 'bimbingan_konselingDataSetAll.Keterangan' table. You can move, or remove it, as needed.
            this.keteranganTableAdapter1.Fill(this.bimbingan_konselingDataSetAll.Keterangan);
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Keterangan' table. You can move, or remove it, as needed.
            //this.keteranganTableAdapter.Fill(this.bimbingan_konselingAll.Keterangan);
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Konseling' table. You can move, or remove it, as needed.
            this.konselingTableAdapter.Fill(this.bimbingan_konselingAll.Konseling);
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.bimbingan_konselingAll.Siswa);
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter.Fill(this.bimbingan_konselingAll.Guru);

        }
        void Tampil()
        {
            con.Open();
            string query2 = "SELECT * FROM Konseling";
            SqlDataAdapter baru3 = new SqlDataAdapter(query2, con);
            DataTable br1 = new DataTable();
            baru3.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();

        }
        void bersih()
        {
            nama_lengkap.Text = "";
            id_konseling.Text = "";
            penangganan.Text = "";
            keterangan.Text = "";
            skor.Text = "";
        }
        private void ubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Konseling SET NIS='" + comboBox1.Text + "',Nama_lengkap='" + nama_lengkap.Text + "',NIP='" + comboBox2.Text + "',Id_keterangan='" + comboBox4.Text + "',Tgl='" + tgl.Text + "',Penanganan='" + penangganan.Text + "',Keterangan='" + keterangan.Text + "',Skor='" + skor.Text + "' WHERE Id_konseling ='" + id_konseling.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("BERHASIL DI UBAH");
            Tampil();
            bersih();
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Nama_lengkap from Siswa where NIS = @NIS", con);
            cmd.Parameters.AddWithValue("@NIS", int.Parse(comboBox1.Text));
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                nama_lengkap.Text = da.GetValue(0).ToString();
            }
            con.Close();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Konseling where Id_konseling='" + id_konseling.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Telah Dihapus !!");
            Tampil();
            bersih();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_konseling.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nama_lengkap.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tgl.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(); 
            penangganan.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            keterangan.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            skor.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Halaman_utama halut = new Halaman_utama();
            halut.Show();
            this.Hide();
        }
    }
}
