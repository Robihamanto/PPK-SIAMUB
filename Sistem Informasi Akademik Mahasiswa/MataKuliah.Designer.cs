namespace Sistem_Informasi_Akademik_Mahasiswa
{
    partial class FormMataKuliah
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
            this.labelKode = new System.Windows.Forms.Label();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.labelNamaMatkul = new System.Windows.Forms.Label();
            this.textBoxNamaMatkul = new System.Windows.Forms.TextBox();
            this.labelSks = new System.Windows.Forms.Label();
            this.textBoxJumlahSks = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columKode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanelCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCrud
            // 
            this.flowLayoutPanelCrud.Controls.Add(this.labelKode);
            this.flowLayoutPanelCrud.Controls.Add(this.textBoxKode);
            this.flowLayoutPanelCrud.Controls.Add(this.labelNamaMatkul);
            this.flowLayoutPanelCrud.Controls.Add(this.textBoxNamaMatkul);
            this.flowLayoutPanelCrud.Controls.Add(this.labelSks);
            this.flowLayoutPanelCrud.Controls.Add(this.textBoxJumlahSks);
            this.flowLayoutPanelCrud.Controls.Add(this.buttonSave);
            this.flowLayoutPanelCrud.Controls.Add(this.buttonUpdate);
            this.flowLayoutPanelCrud.Controls.Add(this.buttonDelete);
            this.flowLayoutPanelCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelCrud.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelCrud.Name = "flowLayoutPanelCrud";
            this.flowLayoutPanelCrud.Size = new System.Drawing.Size(804, 32);
            this.flowLayoutPanelCrud.TabIndex = 2;
            // 
            // labelKode
            // 
            this.labelKode.AutoSize = true;
            this.labelKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKode.Location = new System.Drawing.Point(3, 0);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(46, 20);
            this.labelKode.TabIndex = 1;
            this.labelKode.Text = "Kode";
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(55, 3);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(100, 20);
            this.textBoxKode.TabIndex = 9;
            // 
            // labelNamaMatkul
            // 
            this.labelNamaMatkul.AutoSize = true;
            this.labelNamaMatkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMatkul.Location = new System.Drawing.Point(161, 0);
            this.labelNamaMatkul.Name = "labelNamaMatkul";
            this.labelNamaMatkul.Size = new System.Drawing.Size(138, 20);
            this.labelNamaMatkul.TabIndex = 8;
            this.labelNamaMatkul.Text = "Nama Mata Kuliah";
            // 
            // textBoxNamaMatkul
            // 
            this.textBoxNamaMatkul.Location = new System.Drawing.Point(305, 3);
            this.textBoxNamaMatkul.Name = "textBoxNamaMatkul";
            this.textBoxNamaMatkul.Size = new System.Drawing.Size(100, 20);
            this.textBoxNamaMatkul.TabIndex = 10;
            // 
            // labelSks
            // 
            this.labelSks.AutoSize = true;
            this.labelSks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSks.Location = new System.Drawing.Point(411, 0);
            this.labelSks.Name = "labelSks";
            this.labelSks.Size = new System.Drawing.Size(91, 20);
            this.labelSks.TabIndex = 6;
            this.labelSks.Text = "Jumlah Sks";
            // 
            // textBoxJumlahSks
            // 
            this.textBoxJumlahSks.Location = new System.Drawing.Point(508, 3);
            this.textBoxJumlahSks.Name = "textBoxJumlahSks";
            this.textBoxJumlahSks.Size = new System.Drawing.Size(40, 20);
            this.textBoxJumlahSks.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(554, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(635, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(716, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(341, 181);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "Id";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columKode,
            this.columnNama,
            this.columnSks});
            this.listView1.Location = new System.Drawing.Point(100, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 287);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            // 
            // columKode
            // 
            this.columKode.Text = "Kode";
            this.columKode.Width = 131;
            // 
            // columnNama
            // 
            this.columnNama.Text = "Nama Mata Kuliah";
            this.columnNama.Width = 165;
            // 
            // columnSks
            // 
            this.columnSks.Text = "Jumlah Sks";
            this.columnSks.Width = 95;
            // 
            // FormMataKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanelCrud);
            this.Controls.Add(this.labelId);
            this.Name = "FormMataKuliah";
            this.Text = "MataKuliah";
            this.flowLayoutPanelCrud.ResumeLayout(false);
            this.flowLayoutPanelCrud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCrud;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.Label labelNamaMatkul;
        private System.Windows.Forms.Label labelSks;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxNamaMatkul;
        private System.Windows.Forms.TextBox textBoxJumlahSks;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columKode;
        private System.Windows.Forms.ColumnHeader columnNama;
        private System.Windows.Forms.ColumnHeader columnSks;
    }
}