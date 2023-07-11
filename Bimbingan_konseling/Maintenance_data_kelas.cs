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
    public partial class Maintenance_data_kelas : Form
    {
        public Maintenance_data_kelas()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");

        void Tampil()
        {
            con.Open();
            string query2 = "SELECT * FROM Kelas";
            SqlDataAdapter baru3 = new SqlDataAdapter(query2, con);
            DataTable br1 = new DataTable();
            baru3.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();
        }
        void Bersih()
        {
            id_kls.Text="";
            nama_kls.Text="";
            sub_kls.Text="";
        }
        private void ubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Kelas SET Nama_kelas='" + nama_kls.Text + "',Sub_kelas='" + sub_kls.Text + "',NIP='" + comboBox1.Text + "' WHERE Id_kelas ='" + id_kls.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("BERHASIL DI UBAH");
            Tampil();
            Bersih();
            
        }
        

        private void Maintenance_data_kelas_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Kelas";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            DataTable br1 = new DataTable();
            baru1.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();

            // TODO: This line of code loads data into the 'bimbingan_konselingDataSetAll.Guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter.Fill(this.bimbingan_konselingDataSetAll.Guru);

        }

        private void hapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Kelas where Id_kelas='" + id_kls.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Telah Dihapus !!");
            Tampil();
            Bersih();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_kls.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nama_kls.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            sub_kls.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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
