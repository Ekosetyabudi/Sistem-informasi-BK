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
    public partial class Maintenance_data_siswa : Form
    {
        public Maintenance_data_siswa()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
       
        private void Maintenance_data_siswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Kelas' table. You can move, or remove it, as needed.
            this.kelasTableAdapter.Fill(this.bimbingan_konselingAll.Kelas);

            con.Open();
            string queryy = "SELECT * FROM Siswa";
            SqlDataAdapter baruu = new SqlDataAdapter(queryy, con);
            DataTable br1 = new DataTable();
            baruu.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();

        }
        void Tampil()
        {
            con.Open();
            string query2 = "SELECT * FROM Siswa";
            SqlDataAdapter baru3 = new SqlDataAdapter(query2, con);
            DataTable br1 = new DataTable();
            baru3.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();

        }
        void Bersih()
        {
            nis.Text = "";
            nama.Text = "";
            alamat.Text = "";
            namaortu.Text = "";
            pekerjaan.Text = "";
            no_tlp.Text = "";
            status.Text = "";
        }

        private void ubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Siswa SET Nama_lengkap='" + nama.Text + "',Tgl_lahir='" + dateTimePicker1.Text + "',Id_kelas='" + comboBox2.Text + "',Alamat='" + alamat.Text + "',JK='" + comboBox1.Text + "',Nama_ortu='" + namaortu.Text + "',Pekerjaan_ortu='" + pekerjaan.Text + "',No_tlp='" + no_tlp.Text + "',Status='" + status.Text + "' WHERE NIS ='" + nis.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("BERHASIL DI UBAH");
            Tampil();
            Bersih();
        }

        private void HAPUS_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Siswa Where NIS='" + nis.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Telah Dihapus !!");
            Tampil();
            Bersih();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string qry = "SELECT * FROM Siswa Where Id_kelas'"+textBox1.Text+"'";
            SqlDataAdapter bar = new SqlDataAdapter(qry, con);
            DataTable br1 = new DataTable();
            bar.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            nis.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nama.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            alamat.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            namaortu.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            pekerjaan.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            no_tlp.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            status.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Halaman_utama halut = new Halaman_utama();
            halut.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
