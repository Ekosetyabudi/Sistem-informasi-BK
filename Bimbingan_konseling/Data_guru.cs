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
    public partial class Data_guru : Form
    {
        public Data_guru()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
        private void sub_kls_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void Tampil()
        {
            con.Open();
            string query2 = "SELECT * FROM Guru";
            SqlDataAdapter baru3 = new SqlDataAdapter(query2, con);
            DataTable br1 = new DataTable();
            baru3.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();
        }
        void Bersih()
        {
            NIP.Text = "";
            nama_guru.Text="";
            EmailTlp.Text = "";
            password.Text = "";

        }
        private void ubah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Guru SET Nama_guru='" + nama_guru.Text + "',EmailTlp='" + EmailTlp.Text + "',Password='" + password.Text +"' WHERE NIP ='" + NIP.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("BERHASIL DI UBAH");
            Tampil();
            Bersih();
            
        }

        private void Tampil_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NIP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nama_guru.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            EmailTlp.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            password.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Data_guru_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Guru";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            DataTable br1 = new DataTable();
            baru1.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();

        }

        private void hapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Guru where NIP='" + NIP.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Telah Dihapus !!");
            Tampil();
            Bersih();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Halaman_utama panggil = new Halaman_utama();
            panggil.Show();
            this.Hide();
        }
    }
}
