namespace Bimbingan_konseling
{
    partial class M_Data_Siswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Data_Siswa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.edt_penguna = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nis = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.namaortu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pekerjaan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.no_tlp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_simpan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_batal = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimbingan_konselingAll = new Bimbingan_konseling.Bimbingan_konselingAll();
            this.bimbingan_konselingDataSet = new Bimbingan_konseling.Bimbingan_konselingDataSet();
            this.bimbingankonselingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kelasTableAdapter = new Bimbingan_konseling.Bimbingan_konselingAllTableAdapters.KelasTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingankonselingDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.edt_penguna);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 62);
            this.panel1.TabIndex = 0;
            // 
            // edt_penguna
            // 
            this.edt_penguna.Enabled = false;
            this.edt_penguna.Location = new System.Drawing.Point(690, 38);
            this.edt_penguna.Name = "edt_penguna";
            this.edt_penguna.Size = new System.Drawing.Size(100, 20);
            this.edt_penguna.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(624, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Master data Siswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Induk Siswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Lengkap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status";
            // 
            // nis
            // 
            this.nis.Location = new System.Drawing.Point(170, 77);
            this.nis.Name = "nis";
            this.nis.Size = new System.Drawing.Size(174, 20);
            this.nis.TabIndex = 8;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(170, 116);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(174, 20);
            this.nama.TabIndex = 9;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(170, 232);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(222, 59);
            this.alamat.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.comboBox1.Location = new System.Drawing.Point(170, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(170, 337);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(174, 20);
            this.status.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // namaortu
            // 
            this.namaortu.Location = new System.Drawing.Point(633, 81);
            this.namaortu.Name = "namaortu";
            this.namaortu.Size = new System.Drawing.Size(174, 20);
            this.namaortu.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nama Orang Tua";
            // 
            // pekerjaan
            // 
            this.pekerjaan.Location = new System.Drawing.Point(633, 131);
            this.pekerjaan.Name = "pekerjaan";
            this.pekerjaan.Size = new System.Drawing.Size(174, 20);
            this.pekerjaan.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pekerjaan";
            // 
            // no_tlp
            // 
            this.no_tlp.Location = new System.Drawing.Point(633, 177);
            this.no_tlp.Name = "no_tlp";
            this.no_tlp.Size = new System.Drawing.Size(174, 20);
            this.no_tlp.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "No Telephone";
            // 
            // bt_simpan
            // 
            this.bt_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_simpan.Location = new System.Drawing.Point(493, 358);
            this.bt_simpan.Name = "bt_simpan";
            this.bt_simpan.Size = new System.Drawing.Size(134, 64);
            this.bt_simpan.TabIndex = 21;
            this.bt_simpan.Text = "SIMPAN";
            this.bt_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_simpan.UseVisualStyleBackColor = true;
            this.bt_simpan.Click += new System.EventHandler(this.bt_simpan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(660, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // bt_batal
            // 
            this.bt_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_batal.Location = new System.Drawing.Point(643, 358);
            this.bt_batal.Name = "bt_batal";
            this.bt_batal.Size = new System.Drawing.Size(134, 64);
            this.bt_batal.TabIndex = 23;
            this.bt_batal.Text = "REFRESH";
            this.bt_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_batal.UseVisualStyleBackColor = true;
            this.bt_batal.Click += new System.EventHandler(this.bt_batal_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.kelasBindingSource;
            this.comboBox2.DisplayMember = "Id_kelas";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.ValueMember = "Id_kelas";
            // 
            // kelasBindingSource
            // 
            this.kelasBindingSource.DataMember = "Kelas";
            this.kelasBindingSource.DataSource = this.bimbingan_konselingAll;
            // 
            // bimbingan_konselingAll
            // 
            this.bimbingan_konselingAll.DataSetName = "Bimbingan_konselingAll";
            this.bimbingan_konselingAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bimbingan_konselingDataSet
            // 
            this.bimbingan_konselingDataSet.DataSetName = "Bimbingan_konselingDataSet";
            this.bimbingan_konselingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bimbingankonselingDataSetBindingSource
            // 
            this.bimbingankonselingDataSetBindingSource.DataSource = this.bimbingan_konselingDataSet;
            this.bimbingankonselingDataSetBindingSource.Position = 0;
            // 
            // kelasTableAdapter
            // 
            this.kelasTableAdapter.ClearBeforeFill = true;
            // 
            // M_Data_Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(819, 434);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_batal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_simpan);
            this.Controls.Add(this.no_tlp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pekerjaan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.namaortu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "M_Data_Siswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M_Data_Siswa";
            this.Load += new System.EventHandler(this.M_Data_Siswa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingankonselingDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nis;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox namaortu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pekerjaan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox no_tlp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_simpan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_batal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private Bimbingan_konselingDataSet bimbingan_konselingDataSet;
        private System.Windows.Forms.BindingSource bimbingankonselingDataSetBindingSource;
        private Bimbingan_konselingAll bimbingan_konselingAll;
        private System.Windows.Forms.BindingSource kelasBindingSource;
        private Bimbingan_konselingAllTableAdapters.KelasTableAdapter kelasTableAdapter;
        public System.Windows.Forms.TextBox edt_penguna;
    }
}