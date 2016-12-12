namespace Sistem_Informasi_Akademik_Mahasiswa
{
    partial class FormLogin
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
            this.textBoxNim = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.linkLabelLupaKataSandi = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxNim
            // 
            this.textBoxNim.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNim.Location = new System.Drawing.Point(345, 30);
            this.textBoxNim.Name = "textBoxNim";
            this.textBoxNim.Size = new System.Drawing.Size(129, 20);
            this.textBoxNim.TabIndex = 0;
            this.textBoxNim.Text = "145150207111067";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPassword.Location = new System.Drawing.Point(480, 30);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(129, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMasuk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMasuk.Location = new System.Drawing.Point(615, 29);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(75, 23);
            this.buttonMasuk.TabIndex = 2;
            this.buttonMasuk.Text = "Masuk";
            this.buttonMasuk.UseVisualStyleBackColor = false;
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
            // 
            // linkLabelLupaKataSandi
            // 
            this.linkLabelLupaKataSandi.AutoSize = true;
            this.linkLabelLupaKataSandi.Location = new System.Drawing.Point(598, 55);
            this.linkLabelLupaKataSandi.Name = "linkLabelLupaKataSandi";
            this.linkLabelLupaKataSandi.Size = new System.Drawing.Size(92, 13);
            this.linkLabelLupaKataSandi.TabIndex = 3;
            this.linkLabelLupaKataSandi.TabStop = true;
            this.linkLabelLupaKataSandi.Text = "Lupa Kata Sandi?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.linkLabelLupaKataSandi);
            this.Controls.Add(this.buttonMasuk);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNim);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNim;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonMasuk;
        private System.Windows.Forms.LinkLabel linkLabelLupaKataSandi;
    }
}

