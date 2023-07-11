namespace Bimbingan_konseling
{
    partial class Maintenance_konseling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance_konseling));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_konseling = new System.Windows.Forms.TextBox();
            this.nama_lengkap = new System.Windows.Forms.TextBox();
            this.skor = new System.Windows.Forms.TextBox();
            this.penangganan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ubah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimbingan_konselingAll = new Bimbingan_konseling.Bimbingan_konselingAll();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.guruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.guruTableAdapter = new Bimbingan_konseling.Bimbingan_konselingAllTableAdapters.GuruTableAdapter();
            this.siswaTableAdapter = new Bimbingan_konseling.Bimbingan_konselingAllTableAdapters.SiswaTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.keteranganBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bimbingan_konselingDataSetAll = new Bimbingan_konseling.Bimbingan_konselingDataSetAll();
            this.konselingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konselingTableAdapter = new Bimbingan_konseling.Bimbingan_konselingAllTableAdapters.KonselingTableAdapter();
            this.keteranganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keteranganTableAdapter = new Bimbingan_konseling.Bimbingan_konselingAllTableAdapters.KeteranganTableAdapter();
            this.keteranganTableAdapter1 = new Bimbingan_konseling.Bimbingan_konselingDataSetAllTableAdapters.KeteranganTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.keteranganBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tgl = new System.Windows.Forms.TextBox();
            this.keterangan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konselingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 66);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(663, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance Data Konseling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Konseling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "No Induk Siswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Lengkap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Id Keterangan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Skor";
            // 
            // id_konseling
            // 
            this.id_konseling.Location = new System.Drawing.Point(169, 79);
            this.id_konseling.Name = "id_konseling";
            this.id_konseling.Size = new System.Drawing.Size(167, 20);
            this.id_konseling.TabIndex = 7;
            // 
            // nama_lengkap
            // 
            this.nama_lengkap.Location = new System.Drawing.Point(169, 151);
            this.nama_lengkap.Name = "nama_lengkap";
            this.nama_lengkap.Size = new System.Drawing.Size(167, 20);
            this.nama_lengkap.TabIndex = 9;
            // 
            // skor
            // 
            this.skor.Location = new System.Drawing.Point(169, 247);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(95, 20);
            this.skor.TabIndex = 11;
            // 
            // penangganan
            // 
            this.penangganan.Location = new System.Drawing.Point(505, 115);
            this.penangganan.Multiline = true;
            this.penangganan.Name = "penangganan";
            this.penangganan.Size = new System.Drawing.Size(167, 70);
            this.penangganan.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Penanganan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 137);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ubah
            // 
            this.ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah.Location = new System.Drawing.Point(488, 224);
            this.ubah.Name = "ubah";
            this.ubah.Size = new System.Drawing.Size(116, 57);
            this.ubah.TabIndex = 15;
            this.ubah.Text = "UBAH";
            this.ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ubah.UseVisualStyleBackColor = true;
            this.ubah.Click += new System.EventHandler(this.ubah_Click);
            // 
            // hapus
            // 
            this.hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.Location = new System.Drawing.Point(620, 224);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(116, 57);
            this.hapus.TabIndex = 16;
            this.hapus.Text = "HAPUS";
            this.hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(632, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.siswaBindingSource;
            this.comboBox1.DisplayMember = "Nis";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "Nis";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.bimbingan_konselingAll;
            // 
            // bimbingan_konselingAll
            // 
            this.bimbingan_konselingAll.DataSetName = "Bimbingan_konselingAll";
            this.bimbingan_konselingAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.guruBindingSource;
            this.comboBox2.DisplayMember = "NIP";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(505, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "NIP";
            // 
            // guruBindingSource
            // 
            this.guruBindingSource.DataMember = "Guru";
            this.guruBindingSource.DataSource = this.bimbingan_konselingAll;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "No Induk Pegawai";
            // 
            // guruTableAdapter
            // 
            this.guruTableAdapter.ClearBeforeFill = true;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.keteranganBindingSource1;
            this.comboBox3.DisplayMember = "Keterangan";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(169, 190);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(0, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "Id_keterangan";
            // 
            // keteranganBindingSource1
            // 
            this.keteranganBindingSource1.DataMember = "Keterangan";
            this.keteranganBindingSource1.DataSource = this.bimbingan_konselingDataSetAll;
            // 
            // bimbingan_konselingDataSetAll
            // 
            this.bimbingan_konselingDataSetAll.DataSetName = "Bimbingan_konselingDataSetAll";
            this.bimbingan_konselingDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // konselingBindingSource
            // 
            this.konselingBindingSource.DataMember = "Konseling";
            this.konselingBindingSource.DataSource = this.bimbingan_konselingAll;
            // 
            // konselingTableAdapter
            // 
            this.konselingTableAdapter.ClearBeforeFill = true;
            // 
            // keteranganBindingSource
            // 
            this.keteranganBindingSource.DataMember = "Keterangan";
            this.keteranganBindingSource.DataSource = this.bimbingan_konselingAll;
            // 
            // keteranganTableAdapter
            // 
            this.keteranganTableAdapter.ClearBeforeFill = true;
            // 
            // keteranganTableAdapter1
            // 
            this.keteranganTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.keteranganBindingSource2;
            this.comboBox4.DisplayMember = "Id_keterangan";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(169, 189);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(167, 21);
            this.comboBox4.TabIndex = 23;
            this.comboBox4.ValueMember = "Id_keterangan";
            this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
            // 
            // keteranganBindingSource2
            // 
            this.keteranganBindingSource2.DataMember = "Keterangan";
            this.keteranganBindingSource2.DataSource = this.bimbingan_konselingDataSetAll;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tanggal";
            // 
            // tgl
            // 
            this.tgl.Location = new System.Drawing.Point(505, 83);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(167, 20);
            this.tgl.TabIndex = 25;
            // 
            // keterangan
            // 
            this.keterangan.Location = new System.Drawing.Point(169, 217);
            this.keterangan.Name = "keterangan";
            this.keterangan.Size = new System.Drawing.Size(167, 20);
            this.keterangan.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Keterangan";
            // 
            // Maintenance_konseling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(819, 434);
            this.Controls.Add(this.keterangan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.ubah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.penangganan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.nama_lengkap);
            this.Controls.Add(this.id_konseling);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Maintenance_konseling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance_konseling";
            this.Load += new System.EventHandler(this.Maintenance_konseling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konselingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_konseling;
        private System.Windows.Forms.TextBox nama_lengkap;
        private System.Windows.Forms.TextBox skor;
        private System.Windows.Forms.TextBox penangganan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ubah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private Bimbingan_konselingAll bimbingan_konselingAll;
        private System.Windows.Forms.BindingSource guruBindingSource;
        private Bimbingan_konselingAllTableAdapters.GuruTableAdapter guruTableAdapter;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private Bimbingan_konselingAllTableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource konselingBindingSource;
        private Bimbingan_konselingAllTableAdapters.KonselingTableAdapter konselingTableAdapter;
        private System.Windows.Forms.BindingSource keteranganBindingSource;
        private Bimbingan_konselingAllTableAdapters.KeteranganTableAdapter keteranganTableAdapter;
        private Bimbingan_konselingDataSetAll bimbingan_konselingDataSetAll;
        private System.Windows.Forms.BindingSource keteranganBindingSource1;
        private Bimbingan_konselingDataSetAllTableAdapters.KeteranganTableAdapter keteranganTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource keteranganBindingSource2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tgl;
        private System.Windows.Forms.TextBox keterangan;
        private System.Windows.Forms.Label label10;
    }
}