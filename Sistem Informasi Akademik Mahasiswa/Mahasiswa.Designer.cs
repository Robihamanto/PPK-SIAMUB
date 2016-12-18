namespace Sistem_Informasi_Akademik_Mahasiswa
{
    partial class Mahasiswa
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columNim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFakultas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJurusan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNim = new System.Windows.Forms.Label();
            this.textBoxNim = new System.Windows.Forms.TextBox();
            this.labelFakultas = new System.Windows.Forms.Label();
            this.labelJurusan = new System.Windows.Forms.Label();
            this.comboBoxFakultas = new System.Windows.Forms.ComboBox();
            this.comboBoxJurusan = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNo,
            this.columNim,
            this.columnNama,
            this.columnFakultas,
            this.columnJurusan});
            this.listView1.Location = new System.Drawing.Point(168, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 287);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnNo
            // 
            this.columnNo.Text = "NO";
            // 
            // columnNama
            // 
            this.columnNama.Text = "NAMA";
            this.columnNama.Width = 104;
            // 
            // columNim
            // 
            this.columNim.Text = "NIM";
            this.columNim.Width = 158;
            // 
            // columnFakultas
            // 
            this.columnFakultas.Text = "FAKULTAS";
            this.columnFakultas.Width = 165;
            // 
            // columnJurusan
            // 
            this.columnJurusan.Text = "JURUSAN";
            this.columnJurusan.Width = 132;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(62, 119);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 2;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(14, 122);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(44, 13);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "Nama : ";
            // 
            // labelNim
            // 
            this.labelNim.AutoSize = true;
            this.labelNim.Location = new System.Drawing.Point(14, 96);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(34, 13);
            this.labelNim.TabIndex = 5;
            this.labelNim.Text = "Nim : ";
            // 
            // textBoxNim
            // 
            this.textBoxNim.Location = new System.Drawing.Point(62, 93);
            this.textBoxNim.Name = "textBoxNim";
            this.textBoxNim.Size = new System.Drawing.Size(100, 20);
            this.textBoxNim.TabIndex = 4;
            // 
            // labelFakultas
            // 
            this.labelFakultas.AutoSize = true;
            this.labelFakultas.Location = new System.Drawing.Point(14, 145);
            this.labelFakultas.Name = "labelFakultas";
            this.labelFakultas.Size = new System.Drawing.Size(53, 13);
            this.labelFakultas.TabIndex = 7;
            this.labelFakultas.Text = "Fakultas :";
            // 
            // labelJurusan
            // 
            this.labelJurusan.AutoSize = true;
            this.labelJurusan.Location = new System.Drawing.Point(14, 171);
            this.labelJurusan.Name = "labelJurusan";
            this.labelJurusan.Size = new System.Drawing.Size(50, 13);
            this.labelJurusan.TabIndex = 9;
            this.labelJurusan.Text = "Jurusan :";
            // 
            // comboBoxFakultas
            // 
            this.comboBoxFakultas.FormattingEnabled = true;
            this.comboBoxFakultas.Items.AddRange(new object[] {
            "Ilmu Komputer",
            "Ekonomi Bisnis"});
            this.comboBoxFakultas.Location = new System.Drawing.Point(67, 145);
            this.comboBoxFakultas.Name = "comboBoxFakultas";
            this.comboBoxFakultas.Size = new System.Drawing.Size(97, 21);
            this.comboBoxFakultas.TabIndex = 10;
            // 
            // comboBoxJurusan
            // 
            this.comboBoxJurusan.FormattingEnabled = true;
            this.comboBoxJurusan.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Sistem Informasi"});
            this.comboBoxJurusan.Location = new System.Drawing.Point(67, 172);
            this.comboBoxJurusan.Name = "comboBoxJurusan";
            this.comboBoxJurusan.Size = new System.Drawing.Size(97, 21);
            this.comboBoxJurusan.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(67, 209);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(67, 238);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(67, 267);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 387);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxJurusan);
            this.Controls.Add(this.comboBoxFakultas);
            this.Controls.Add(this.labelJurusan);
            this.Controls.Add(this.labelFakultas);
            this.Controls.Add(this.labelNim);
            this.Controls.Add(this.textBoxNim);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.listView1);
            this.Name = "Mahasiswa";
            this.Text = "Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnNo;
        private System.Windows.Forms.ColumnHeader columnNama;
        private System.Windows.Forms.ColumnHeader columNim;
        private System.Windows.Forms.ColumnHeader columnFakultas;
        private System.Windows.Forms.ColumnHeader columnJurusan;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNim;
        private System.Windows.Forms.TextBox textBoxNim;
        private System.Windows.Forms.Label labelFakultas;
        private System.Windows.Forms.Label labelJurusan;
        private System.Windows.Forms.ComboBox comboBoxFakultas;
        private System.Windows.Forms.ComboBox comboBoxJurusan;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}