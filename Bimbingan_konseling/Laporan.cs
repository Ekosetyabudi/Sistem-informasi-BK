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
using System.Configuration;
using CrystalDecisions.Shared;

namespace Bimbingan_konseling
{
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {

            //this.crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Bimbingan_konseling.Properties.Settings.Bimbingan_konselingConnectionString"].ToString();

            string sql = "Select * from Konseling Where NIS = '" + textBox1.Text + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
            adapter.Fill(ds, "Konseling");
            DataTable dt = ds.Tables["Konseling"];

            cr.SetDataSource(ds.Tables["Konseling"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
     
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Bimbingan_konseling.Properties.Settings.Bimbingan_konselingConnectionString"].ToString();

            string sql = "SELECT * FROM Konseling where Tgl between  '" + dtDari.Value + "' and '" + dtHingga.Value + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds, "Konseling");
            DataTable dt = ds.Tables["Konseling"];

            cr.SetDataSource(ds.Tables["Konseling"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Halaman_utama halut = new Halaman_utama();
            if (textBox2.Text == "User")
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
    }
}
