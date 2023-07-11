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
    public partial class M_Data_Siswa : Form
    {
        public M_Data_Siswa()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
       
        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if ((nis.Text == "") & (nama.Text == "") & (alamat.Text == "") & (namaortu.Text == "") & (pekerjaan.Text == "") & (no_tlp.Text == "") & (status.Text == ""))
            {
                MessageBox.Show("Data Dimohon Untuk Di Isi");
            }
            else
            {
                SqlDataAdapter sql = new SqlDataAdapter( "Select Nis FROM Siswa Where Nis ='" + nis.Text + "'",con);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("No Induk Siswa Telah Digunakan");
                }
                else
                {
                    con.Open();
                    string query = "INSERT INTO Siswa (Nis, Nama_lengkap, Tgl_lahir, Id_kelas, Alamat, JK, Nama_ortu, Pekerjaan_ortu, No_tlp, Status) VALUES ('" + nis.Text + "','" + nama.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + alamat.Text + "','" + comboBox1.Text + "','" + namaortu.Text + "','" + pekerjaan.Text + "','" + no_tlp.Text + "','" + status.Text + "') ";
                    SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
                    baru1.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Berhasil Ditambahkan");

                }
                    
                    
                    
                
            }
        }

        private void M_Data_Siswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Kelas' table. You can move, or remove it, as needed.
            this.kelasTableAdapter.Fill(this.bimbingan_konselingAll.Kelas);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Halaman_utama halut = new Halaman_utama();
            if (edt_penguna.Text == "User")
            {
                halut.bt_maintenance.Enabled = false;
            }
            else
            {
                halut.bt_maintenance.Enabled = true;
            }
            halut.Show();
            this.Hide();

        }

        private void bt_batal_Click(object sender, EventArgs e)
        {
            nis.Text = "";
            nama.Text = "";
            alamat.Text = "";
            status.Text = "";
            namaortu.Text = "";
            pekerjaan.Text = "";
            no_tlp.Text = "";

        }
    }
}
