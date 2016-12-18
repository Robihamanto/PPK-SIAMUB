namespace Sistem_Informasi_Akademik_Mahasiswa
{
    partial class FormKartuHasilStudiAdmin
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
            this.flowLayoutPanelCrud = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMataKuliah = new System.Windows.Forms.Label();
            this.comboBoxMataKuliah = new System.Windows.Forms.ComboBox();
            this.labelNim = new System.Windows.Forms.Label();
            this.comboBoxNim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNilai = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columMataKuliah = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNilai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanelCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCrud
            // 
            this.flowLayoutPanelCrud.Controls.Add(this.labelMataKuliah);
            this.flowLayoutPanelCrud.Controls.Add(this.comboBoxMataKuliah);
            this.flowLayoutPanelCrud.Controls.Add(this.labelNim);
            this.flowLayoutPanelCrud.Controls.Add(this.comboBoxNim);
            this.flowLayoutPanelCrud.Controls.Add(this.label2);
            this.flowLayoutPanelCrud.Controls.Add(this.comboBoxNilai);
            this.flowLayoutPanelCrud.Controls.Add(this.buttonSave);
            this.flowLayoutPanelCrud.Controls.Add(this.buttonUpdate);
            this.flowLayoutPanelCrud.Controls.Add(this.buttonDelete);
            this.flowLayoutPanelCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelCrud.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelCrud.Name = "flowLayoutPanelCrud";
            this.flowLayoutPanelCrud.Size = new System.Drawing.Size(804, 32);
            this.flowLayoutPanelCrud.TabIndex = 1;
            // 
            // labelMataKuliah
            // 
            this.labelMataKuliah.AutoSize = true;
            this.labelMataKuliah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMataKuliah.Location = new System.Drawing.Point(3, 0);
            this.labelMataKuliah.Name = "labelMataKuliah";
            this.labelMataKuliah.Size = new System.Drawing.Size(86, 20);
            this.labelMataKuliah.TabIndex = 1;
            this.labelMataKuliah.Text = "Matakuliah";
            // 
            // comboBoxMataKuliah
            // 
            this.comboBoxMataKuliah.FormattingEnabled = true;
            this.comboBoxMataKuliah.Location = new System.Drawing.Point(95, 3);
            this.comboBoxMataKuliah.Name = "comboBoxMataKuliah";
            this.comboBoxMataKuliah.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMataKuliah.TabIndex = 7;
            // 
            // labelNim
            // 
            this.labelNim.AutoSize = true;
            this.labelNim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNim.Location = new System.Drawing.Point(222, 0);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(36, 20);
            this.labelNim.TabIndex = 8;
            this.labelNim.Text = "Nim";
            // 
            // comboBoxNim
            // 
            this.comboBoxNim.FormattingEnabled = true;
            this.comboBoxNim.Location = new System.Drawing.Point(264, 3);
            this.comboBoxNim.Name = "comboBoxNim";
            this.comboBoxNim.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nilai";
            // 
            // comboBoxNilai
            // 
            this.comboBoxNilai.FormattingEnabled = true;
            this.comboBoxNilai.Items.AddRange(new object[] {
            "A",
            "B+",
            "B",
            "C+",
            "C",
            "D+",
            "D",
            "E"});
            this.comboBoxNilai.Location = new System.Drawing.Point(435, 3);
            this.comboBoxNilai.Name = "comboBoxNilai";
            this.comboBoxNilai.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNilai.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(562, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(643, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(724, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNo,
            this.columnKode,
            this.columMataKuliah,
            this.columnNim,
            this.columnNama,
            this.columnNilai});
            this.listView1.Location = new System.Drawing.Point(13, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(761, 287);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnNo
            // 
            this.columnNo.Text = "NO";
            // 
            // columnKode
            // 
            this.columnKode.Text = "KODE";
            this.columnKode.Width = 104;
            // 
            // columMataKuliah
            // 
            this.columMataKuliah.Text = "MATA KULIAH";
            this.columMataKuliah.Width = 212;
            // 
            // columnNim
            // 
            this.columnNim.Text = "NIM";
            this.columnNim.Width = 144;
            // 
            // columnNama
            // 
            this.columnNama.Text = "NAMA";
            this.columnNama.Width = 119;
            // 
            // columnNilai
            // 
            this.columnNilai.Text = "NILAI";
            this.columnNilai.Width = 108;
            // 
            // FormKartuHasilStudiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 375);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanelCrud);
            this.Name = "FormKartuHasilStudiAdmin";
            this.Text = "KartuHasilStudi Admin";
            this.flowLayoutPanelCrud.ResumeLayout(false);
            this.flowLayoutPanelCrud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCrud;
        private System.Windows.Forms.ComboBox comboBoxNim;
        private System.Windows.Forms.Label labelMataKuliah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNilai;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxMataKuliah;
        private System.Windows.Forms.Label labelNim;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnNo;
        private System.Windows.Forms.ColumnHeader columnKode;
        private System.Windows.Forms.ColumnHeader columMataKuliah;
        private System.Windows.Forms.ColumnHeader columnNilai;
        private System.Windows.Forms.ColumnHeader columnNim;
        private System.Windows.Forms.ColumnHeader columnNama;
    }
}