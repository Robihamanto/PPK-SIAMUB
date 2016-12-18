namespace Sistem_Informasi_Akademik_Mahasiswa
{
    partial class FormAkademik
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
            this.splitterBiodata = new System.Windows.Forms.Splitter();
            this.linkLabelKartuRencanaStudi = new System.Windows.Forms.LinkLabel();
            this.linkLabelKartuHasilStudi = new System.Windows.Forms.LinkLabel();
            this.linkLabelJadwalKuliah = new System.Windows.Forms.LinkLabel();
            this.linkLabelAbsensi = new System.Windows.Forms.LinkLabel();
            this.labelNim = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelFakultas = new System.Windows.Forms.Label();
            this.LabelJurusan = new System.Windows.Forms.Label();
            this.labelSeleksi = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Labelstatus = new System.Windows.Forms.Label();
            this.linkLabelMataKuliah = new System.Windows.Forms.LinkLabel();
            this.linkLabelKelas = new System.Windows.Forms.LinkLabel();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonUbahFoto = new System.Windows.Forms.Button();
            this.openFileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.linkLabelMahasiswa = new System.Windows.Forms.LinkLabel();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // splitterBiodata
            // 
            this.splitterBiodata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitterBiodata.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterBiodata.Location = new System.Drawing.Point(0, 0);
            this.splitterBiodata.Name = "splitterBiodata";
            this.splitterBiodata.Size = new System.Drawing.Size(701, 221);
            this.splitterBiodata.TabIndex = 2;
            this.splitterBiodata.TabStop = false;
            // 
            // linkLabelKartuRencanaStudi
            // 
            this.linkLabelKartuRencanaStudi.AutoSize = true;
            this.linkLabelKartuRencanaStudi.LinkColor = System.Drawing.Color.Black;
            this.linkLabelKartuRencanaStudi.Location = new System.Drawing.Point(436, 63);
            this.linkLabelKartuRencanaStudi.Name = "linkLabelKartuRencanaStudi";
            this.linkLabelKartuRencanaStudi.Size = new System.Drawing.Size(106, 13);
            this.linkLabelKartuRencanaStudi.TabIndex = 3;
            this.linkLabelKartuRencanaStudi.TabStop = true;
            this.linkLabelKartuRencanaStudi.Text = "Kartu Rencana Studi";
            this.linkLabelKartuRencanaStudi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKartuRencanaStudi_LinkClicked);
            // 
            // linkLabelKartuHasilStudi
            // 
            this.linkLabelKartuHasilStudi.AutoSize = true;
            this.linkLabelKartuHasilStudi.LinkColor = System.Drawing.Color.Black;
            this.linkLabelKartuHasilStudi.Location = new System.Drawing.Point(436, 85);
            this.linkLabelKartuHasilStudi.Name = "linkLabelKartuHasilStudi";
            this.linkLabelKartuHasilStudi.Size = new System.Drawing.Size(85, 13);
            this.linkLabelKartuHasilStudi.TabIndex = 4;
            this.linkLabelKartuHasilStudi.TabStop = true;
            this.linkLabelKartuHasilStudi.Text = "Kartu Hasil Studi";
            this.linkLabelKartuHasilStudi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKartuHasilStudi_LinkClicked);
            // 
            // linkLabelJadwalKuliah
            // 
            this.linkLabelJadwalKuliah.AutoSize = true;
            this.linkLabelJadwalKuliah.LinkColor = System.Drawing.Color.Black;
            this.linkLabelJadwalKuliah.Location = new System.Drawing.Point(436, 107);
            this.linkLabelJadwalKuliah.Name = "linkLabelJadwalKuliah";
            this.linkLabelJadwalKuliah.Size = new System.Drawing.Size(72, 13);
            this.linkLabelJadwalKuliah.TabIndex = 5;
            this.linkLabelJadwalKuliah.TabStop = true;
            this.linkLabelJadwalKuliah.Text = "Jadwal Kuliah";
            this.linkLabelJadwalKuliah.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelJadwalKuliah_LinkClicked);
            // 
            // linkLabelAbsensi
            // 
            this.linkLabelAbsensi.AutoSize = true;
            this.linkLabelAbsensi.LinkColor = System.Drawing.Color.Black;
            this.linkLabelAbsensi.Location = new System.Drawing.Point(436, 129);
            this.linkLabelAbsensi.Name = "linkLabelAbsensi";
            this.linkLabelAbsensi.Size = new System.Drawing.Size(44, 13);
            this.linkLabelAbsensi.TabIndex = 6;
            this.linkLabelAbsensi.TabStop = true;
            this.linkLabelAbsensi.Text = "Absensi";
            // 
            // labelNim
            // 
            this.labelNim.AutoSize = true;
            this.labelNim.Location = new System.Drawing.Point(109, 61);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(97, 13);
            this.labelNim.TabIndex = 7;
            this.labelNim.Text = "145150207111067";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(109, 83);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(95, 15);
            this.labelNama.TabIndex = 8;
            this.labelNama.Text = "ROBIHAMANTO";
            // 
            // labelFakultas
            // 
            this.labelFakultas.AutoSize = true;
            this.labelFakultas.Location = new System.Drawing.Point(109, 105);
            this.labelFakultas.Name = "labelFakultas";
            this.labelFakultas.Size = new System.Drawing.Size(122, 13);
            this.labelFakultas.TabIndex = 9;
            this.labelFakultas.Text = "Jenjang/Fakultas > S1/ ";
            // 
            // LabelJurusan
            // 
            this.LabelJurusan.AutoSize = true;
            this.LabelJurusan.Location = new System.Drawing.Point(109, 127);
            this.LabelJurusan.Name = "LabelJurusan";
            this.LabelJurusan.Size = new System.Drawing.Size(56, 13);
            this.LabelJurusan.TabIndex = 10;
            this.LabelJurusan.Text = "Jurusan > ";
            // 
            // labelSeleksi
            // 
            this.labelSeleksi.AutoSize = true;
            this.labelSeleksi.Location = new System.Drawing.Point(109, 149);
            this.labelSeleksi.Name = "labelSeleksi";
            this.labelSeleksi.Size = new System.Drawing.Size(53, 13);
            this.labelSeleksi.TabIndex = 11;
            this.labelSeleksi.Text = "Seleksi > ";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(109, 185);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(46, 13);
            this.Status.TabIndex = 12;
            this.Status.Text = "Status : ";
            // 
            // Labelstatus
            // 
            this.Labelstatus.AutoSize = true;
            this.Labelstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelstatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Labelstatus.Location = new System.Drawing.Point(161, 182);
            this.Labelstatus.Name = "Labelstatus";
            this.Labelstatus.Size = new System.Drawing.Size(36, 18);
            this.Labelstatus.TabIndex = 13;
            this.Labelstatus.Text = "Aktif";
            // 
            // linkLabelMataKuliah
            // 
            this.linkLabelMataKuliah.AutoSize = true;
            this.linkLabelMataKuliah.LinkColor = System.Drawing.Color.Black;
            this.linkLabelMataKuliah.Location = new System.Drawing.Point(548, 85);
            this.linkLabelMataKuliah.Name = "linkLabelMataKuliah";
            this.linkLabelMataKuliah.Size = new System.Drawing.Size(63, 13);
            this.linkLabelMataKuliah.TabIndex = 15;
            this.linkLabelMataKuliah.TabStop = true;
            this.linkLabelMataKuliah.Text = "Mata Kuliah";
            this.linkLabelMataKuliah.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMataKuliah_LinkClicked);
            // 
            // linkLabelKelas
            // 
            this.linkLabelKelas.AutoSize = true;
            this.linkLabelKelas.LinkColor = System.Drawing.Color.Black;
            this.linkLabelKelas.Location = new System.Drawing.Point(548, 107);
            this.linkLabelKelas.Name = "linkLabelKelas";
            this.linkLabelKelas.Size = new System.Drawing.Size(33, 13);
            this.linkLabelKelas.TabIndex = 17;
            this.linkLabelKelas.TabStop = true;
            this.linkLabelKelas.Text = "Kelas";
            this.linkLabelKelas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNilai_LinkClicked);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(22, 61);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(71, 109);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 19;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonUbahFoto
            // 
            this.buttonUbahFoto.Location = new System.Drawing.Point(22, 180);
            this.buttonUbahFoto.Name = "buttonUbahFoto";
            this.buttonUbahFoto.Size = new System.Drawing.Size(71, 23);
            this.buttonUbahFoto.TabIndex = 20;
            this.buttonUbahFoto.Text = "Ubah Foto";
            this.buttonUbahFoto.UseVisualStyleBackColor = true;
            this.buttonUbahFoto.Click += new System.EventHandler(this.buttonUbahFoto_Click);
            // 
            // openFileDialogFoto
            // 
            this.openFileDialogFoto.FileName = "openFileDialog1";
            // 
            // linkLabelMahasiswa
            // 
            this.linkLabelMahasiswa.AutoSize = true;
            this.linkLabelMahasiswa.LinkColor = System.Drawing.Color.Black;
            this.linkLabelMahasiswa.Location = new System.Drawing.Point(548, 63);
            this.linkLabelMahasiswa.Name = "linkLabelMahasiswa";
            this.linkLabelMahasiswa.Size = new System.Drawing.Size(60, 13);
            this.linkLabelMahasiswa.TabIndex = 22;
            this.linkLabelMahasiswa.TabStop = true;
            this.linkLabelMahasiswa.Text = "Mahasiswa";
            this.linkLabelMahasiswa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMahasiswa_LinkClicked);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Location = new System.Drawing.Point(614, 12);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(75, 23);
            this.buttonKeluar.TabIndex = 24;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormAkademik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(701, 469);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.linkLabelMahasiswa);
            this.Controls.Add(this.buttonUbahFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.linkLabelKelas);
            this.Controls.Add(this.linkLabelMataKuliah);
            this.Controls.Add(this.Labelstatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.labelSeleksi);
            this.Controls.Add(this.LabelJurusan);
            this.Controls.Add(this.labelFakultas);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelNim);
            this.Controls.Add(this.linkLabelAbsensi);
            this.Controls.Add(this.linkLabelJadwalKuliah);
            this.Controls.Add(this.linkLabelKartuHasilStudi);
            this.Controls.Add(this.linkLabelKartuRencanaStudi);
            this.Controls.Add(this.splitterBiodata);
            this.IsMdiContainer = true;
            this.Name = "FormAkademik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akademik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAkademik_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitterBiodata;
        private System.Windows.Forms.LinkLabel linkLabelKartuRencanaStudi;
        private System.Windows.Forms.LinkLabel linkLabelKartuHasilStudi;
        private System.Windows.Forms.LinkLabel linkLabelJadwalKuliah;
        private System.Windows.Forms.LinkLabel linkLabelAbsensi;
        private System.Windows.Forms.Label labelNim;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelFakultas;
        private System.Windows.Forms.Label LabelJurusan;
        private System.Windows.Forms.Label labelSeleksi;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Labelstatus;
        private System.Windows.Forms.LinkLabel linkLabelMataKuliah;
        private System.Windows.Forms.LinkLabel linkLabelKelas;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonUbahFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoto;
        private System.Windows.Forms.LinkLabel linkLabelMahasiswa;
        private System.Windows.Forms.Button buttonKeluar;
    }
}