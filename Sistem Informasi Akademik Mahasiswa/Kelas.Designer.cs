namespace Sistem_Informasi_Akademik_Mahasiswa
{
    partial class Kelas
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
            this.columnKode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columNama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKapasitas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanelCrud = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMataKuliah = new System.Windows.Forms.Label();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.labelNim = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKapasitas = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanelCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNo,
            this.columnKode,
            this.columNama,
            this.columnKapasitas});
            this.listView1.Location = new System.Drawing.Point(106, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 287);
            this.listView1.TabIndex = 0;
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
            // columNama
            // 
            this.columNama.Text = "NAMA KELAS";
            this.columNama.Width = 188;
            // 
            // columnKapasitas
            // 
            this.columnKapasitas.Text = "KAPASITAS";
            this.columnKapasitas.Width = 165;
            // 
            // flowLayoutPanelCrud
            // 
            this.flowLayoutPanelCrud.Controls.Add(this.labelMataKuliah);
            this.flowLayoutPanelCrud.Controls.Add(this.textBoxKode);
            this.flowLayoutPanelCrud.Controls.Add(this.labelNim);
            this.flowLayoutPanelCrud.Controls.Add(this.textBoxNama);
            this.flowLayoutPanelCrud.Controls.Add(this.label2);
            this.flowLayoutPanelCrud.Controls.Add(this.textBoxKapasitas);
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
            this.labelMataKuliah.Size = new System.Drawing.Size(46, 20);
            this.labelMataKuliah.TabIndex = 1;
            this.labelMataKuliah.Text = "Kode";
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(55, 3);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(100, 20);
            this.textBoxKode.TabIndex = 9;
            // 
            // labelNim
            // 
            this.labelNim.AutoSize = true;
            this.labelNim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNim.Location = new System.Drawing.Point(161, 0);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(51, 20);
            this.labelNim.TabIndex = 8;
            this.labelNim.Text = "Nama";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(218, 3);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kapasitas";
            // 
            // textBoxKapasitas
            // 
            this.textBoxKapasitas.Location = new System.Drawing.Point(409, 3);
            this.textBoxKapasitas.Name = "textBoxKapasitas";
            this.textBoxKapasitas.Size = new System.Drawing.Size(100, 20);
            this.textBoxKapasitas.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(515, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(596, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(677, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Kelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 375);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanelCrud);
            this.Name = "Kelas";
            this.Text = "Kelas";
            this.flowLayoutPanelCrud.ResumeLayout(false);
            this.flowLayoutPanelCrud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columNama;
        private System.Windows.Forms.ColumnHeader columnKapasitas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCrud;
        private System.Windows.Forms.Label labelMataKuliah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelNim;
        private System.Windows.Forms.ColumnHeader columnNo;
        private System.Windows.Forms.ColumnHeader columnKode;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKapasitas;
    }
}