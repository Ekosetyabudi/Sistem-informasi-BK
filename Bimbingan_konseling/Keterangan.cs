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
    public partial class Keterangan : Form
    {
        public Keterangan()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
        void Tampil()
        {
            con.Open();
            string queryy = "SELECT * FROM Keterangan";
            SqlDataAdapter baru2 = new SqlDataAdapter(queryy, con);
            DataTable br1 = new DataTable();
            baru2.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();
        }
        void Bersih()
        {
            id_keterangan.Text = "";
            Jns_keterangan.Text = "";
            skor.Text = "";

        }
        private void simpan_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Keterangan (Id_keterangan, keterangan, Skor) VALUES ('" + id_keterangan.Text + "','" + Jns_keterangan.Text + "','" + skor.Text + "') ";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Ditambahkan");
            Tampil();
            Bersih();
            

        }

        private void batal_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Keterangan SET Keterangan='" + Jns_keterangan.Text + "',Skor='" + skor.Text + "' WHERE Id_keterangan ='" + id_keterangan.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("BERHASIL DI UBAH");
            Tampil();
            Bersih();

        }

        private void Keterangan_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Keterangan";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            DataTable br1 = new DataTable();
            baru1.Fill(br1);
            dataGridView1.DataSource = br1;
            con.Close();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_keterangan.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Jns_keterangan.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            skor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Keterangan where Id_keterangan='" + id_keterangan.Text + "'";
            SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
            baru1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Telah Dihapus !!");
            Tampil();
            Bersih();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bersih();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Halaman_utama hu = new Halaman_utama();
            hu.Show();
            this.Hide();
        }
    }
}
