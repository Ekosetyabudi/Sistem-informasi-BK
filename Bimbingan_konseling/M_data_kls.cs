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
    public partial class M_data_kls : Form
    {
        public M_data_kls()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUM094B\SQLEXPRESS;Initial Catalog=Bimbingan_konseling;Integrated Security=True");
        private void simpan_Click(object sender, EventArgs e)
        {
            if ((id_kls.Text=="")&(nama_kls.Text=="")&(sub_kls.Text==""))
            {
                MessageBox.Show("Data Kelas Harap Diisi");

            }else
            {
                SqlDataAdapter sql = new SqlDataAdapter("Select Id_kelas FROM Kelas Where Id_kelas ='" + id_kls.Text + "'", con);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Id Kelas Telah Digunakan");
                }
                else
                {

                    con.Open();
                    string query = "INSERT INTO Kelas (Id_kelas, Nama_kelas, Sub_kelas, NIP) VALUES ('" + id_kls.Text + "','" + nama_kls.Text + "','" + sub_kls.Text + "','" + comboBox1.Text + "') ";
                    SqlDataAdapter baru1 = new SqlDataAdapter(query, con);
                    baru1.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Berhasil Ditambahkan");
                }
            }
        }

        private void M_data_kls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bimbingan_konselingAll.Guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter.Fill(this.bimbingan_konselingAll.Guru);

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

        private void batal_Click(object sender, EventArgs e)
        {
            id_kls.Text = "";
            nama_kls.Text = "";
            sub_kls.Text = "";
        }
    }
}
