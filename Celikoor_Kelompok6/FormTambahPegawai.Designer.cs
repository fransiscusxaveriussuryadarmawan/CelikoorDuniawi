
namespace Celikoor_Kelompok6
{
    partial class FormTambahPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahPegawai));
            this.pictureBoxGaris = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.textBoxUlangPassword = new System.Windows.Forms.TextBox();
            this.labelUlangPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGaris
            // 
            this.pictureBoxGaris.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxGaris.Location = new System.Drawing.Point(-22, -33);
            this.pictureBoxGaris.Name = "pictureBoxGaris";
            this.pictureBoxGaris.Size = new System.Drawing.Size(65, 149);
            this.pictureBoxGaris.TabIndex = 136;
            this.pictureBoxGaris.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, -10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 126);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 135;
            this.pictureBoxLogo.TabStop = false;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Trebuchet MS", 10.8F);
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxShowPass.Location = new System.Drawing.Point(665, 577);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(158, 28);
            this.checkBoxShowPass.TabIndex = 134;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Tan;
            this.buttonKosongi.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(351, 640);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(163, 48);
            this.buttonKosongi.TabIndex = 130;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(301, 355);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(522, 39);
            this.textBoxPassword.TabIndex = 129;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(301, 282);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(522, 39);
            this.textBoxUsername.TabIndex = 128;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(58, 508);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(68, 36);
            this.labelRole.TabIndex = 123;
            this.labelRole.Text = "Role";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(58, 150);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(86, 36);
            this.labelNama.TabIndex = 122;
            this.labelNama.Text = "Nama";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(301, 150);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(522, 39);
            this.textBoxNama.TabIndex = 121;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(60, 220);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(84, 36);
            this.labelEmail.TabIndex = 120;
            this.labelEmail.Text = "Email";
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.Tan;
            this.buttonKembali.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(665, 640);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(168, 48);
            this.buttonKembali.TabIndex = 119;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Tan;
            this.buttonSimpan.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(41, 640);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(163, 48);
            this.buttonSimpan.TabIndex = 118;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(58, 356);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(130, 36);
            this.labelPassword.TabIndex = 116;
            this.labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(301, 217);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(522, 39);
            this.textBoxEmail.TabIndex = 115;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(58, 282);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(146, 36);
            this.labelUsername.TabIndex = 114;
            this.labelUsername.Text = "Username ";
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Tan;
            this.labelJudul.Font = new System.Drawing.Font("Trebuchet MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(49, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(864, 116);
            this.labelJudul.TabIndex = 113;
            this.labelJudul.Text = "Celikoor 21";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.Font = new System.Drawing.Font("Trebuchet MS", 16.2F);
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Items.AddRange(new object[] {
            "ADMIN",
            "KASIR",
            "OPERATOR"});
            this.comboBoxRoles.Location = new System.Drawing.Point(301, 508);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(522, 43);
            this.comboBoxRoles.TabIndex = 137;
            // 
            // textBoxUlangPassword
            // 
            this.textBoxUlangPassword.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUlangPassword.Location = new System.Drawing.Point(301, 429);
            this.textBoxUlangPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUlangPassword.Name = "textBoxUlangPassword";
            this.textBoxUlangPassword.Size = new System.Drawing.Size(522, 39);
            this.textBoxUlangPassword.TabIndex = 142;
            // 
            // labelUlangPassword
            // 
            this.labelUlangPassword.AutoSize = true;
            this.labelUlangPassword.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUlangPassword.Location = new System.Drawing.Point(58, 430);
            this.labelUlangPassword.Name = "labelUlangPassword";
            this.labelUlangPassword.Size = new System.Drawing.Size(208, 36);
            this.labelUlangPassword.TabIndex = 141;
            this.labelUlangPassword.Text = "Ulang Password";
            // 
            // FormTambahPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(892, 729);
            this.Controls.Add(this.textBoxUlangPassword);
            this.Controls.Add(this.labelUlangPassword);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.pictureBoxGaris);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Pegawai";
            this.Load += new System.EventHandler(this.FormTambahPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGaris;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        public System.Windows.Forms.TextBox textBoxUlangPassword;
        private System.Windows.Forms.Label labelUlangPassword;
    }
}