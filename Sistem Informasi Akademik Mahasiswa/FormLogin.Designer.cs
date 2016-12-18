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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxNim = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.linkLabelLupaKataSandi = new System.Windows.Forms.LinkLabel();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNim
            // 
            this.textBoxNim.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNim.Location = new System.Drawing.Point(47, 62);
            this.textBoxNim.Name = "textBoxNim";
            this.textBoxNim.Size = new System.Drawing.Size(129, 20);
            this.textBoxNim.TabIndex = 0;
            this.textBoxNim.Text = "145150207111067";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPassword.Location = new System.Drawing.Point(182, 62);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(129, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "asdasd";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMasuk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMasuk.Location = new System.Drawing.Point(317, 61);
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
            this.linkLabelLupaKataSandi.Location = new System.Drawing.Point(300, 87);
            this.linkLabelLupaKataSandi.Name = "linkLabelLupaKataSandi";
            this.linkLabelLupaKataSandi.Size = new System.Drawing.Size(92, 13);
            this.linkLabelLupaKataSandi.TabIndex = 3;
            this.linkLabelLupaKataSandi.TabStop = true;
            this.linkLabelLupaKataSandi.Text = "Lupa Kata Sandi?";
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Checked = true;
            this.checkBoxRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemember.Location = new System.Drawing.Point(47, 88);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(126, 17);
            this.checkBoxRemember.TabIndex = 4;
            this.checkBoxRemember.Text = "Remember Password";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(177, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 25);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "SIAMPAS";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 151);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.linkLabelLupaKataSandi);
            this.Controls.Add(this.buttonMasuk);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNim;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonMasuk;
        private System.Windows.Forms.LinkLabel linkLabelLupaKataSandi;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.Label labelTitle;
    }
}

