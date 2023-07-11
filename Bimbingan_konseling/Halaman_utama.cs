using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bimbingan_konseling
{
    public partial class Halaman_utama : Form
    {
        public Halaman_utama()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Data_guru h = new Data_guru();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Maintenance_data_kelas g = new Maintenance_data_kelas();
            g.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Maintenance_data_siswa f = new Maintenance_data_siswa();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Maintenance_konseling d = new Maintenance_konseling();
            d.Show();
            this.Hide();
        }

        private void bt_maintenance_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            if  (panel2.Height != 0) 
            {
                panel2.Height = 0;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Height = 258;
                timer1.Stop();
        }

        private void bt_Master_Click(object sender, EventArgs e)
        {
            timer2.Start();
            if (panel3.Height != 0)
            {
                panel3.Height = 0;
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel3.Height = 99;
            timer2.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            M_Data_Siswa c = new M_Data_Siswa();
            if (bt_maintenance.Enabled == false)
            {
                c.edt_penguna.Text = "User";
            }
            else
            {
                c.edt_penguna.Text = "Admin";
            }
            c.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            M_data_kls b = new M_data_kls();
            if (bt_maintenance.Enabled == false)
            {
                b.edt_penguna.Text = "User";
            }
            else
            {
                b.edt_penguna.Text = "Admin";
            }
            b.Show();
            this.Hide();
        }

        private void bt_histori_Click(object sender, EventArgs e)
        {
            histori_konseling p = new histori_konseling();
            if (bt_maintenance.Enabled == false)
            {
                p.edt_penguna.Text = "User";
            }
            else
            {
                p.edt_penguna.Text = "Admin";
            }
            p.Show();
            this.Hide();
        }

        private void bt_konseling_Click(object sender, EventArgs e)
        {
            F_Konseling a = new F_Konseling();
            if( bt_maintenance.Enabled == false)
            {
             a.edt_penguna.Text= "User";   
            }
            else
            {
                a.edt_penguna.Text = "Admin";
            }
            a.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Keterangan M = new Keterangan();
            M.Show();
            this.Hide();

        }

        private void Halaman_utama_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            F_Login fl = new F_Login();
            fl.Show();
            this.Hide();
        }
            
    }
}
