namespace Sistem_Informasi_Akademik_Mahasiswa
{
    partial class FormKartuHasilStudi
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
            this.columMataKuliah = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNilai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columMataKuliah,
            this.columnNilai});
            this.listView1.Location = new System.Drawing.Point(-1, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 287);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columMataKuliah
            // 
            this.columMataKuliah.Text = "Mata Kuliah";
            // 
            // columnNilai
            // 
            this.columnNilai.Text = "Nilai";
            this.columnNilai.Width = 49;
            // 
            // FormKartuHasilStudi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 315);
            this.Controls.Add(this.listView1);
            this.Name = "FormKartuHasilStudi";
            this.Text = "KartuHasilStudi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columMataKuliah;
        private System.Windows.Forms.ColumnHeader columnNilai;
    }
}