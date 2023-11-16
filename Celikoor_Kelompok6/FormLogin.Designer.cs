
namespace Celikoor_Kelompok6
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.labelUname = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 61);
            this.label1.TabIndex = 28;
            this.label1.Text = "Celikoor 21 Cineplex";
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkRegister.Location = new System.Drawing.Point(541, 329);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(177, 24);
            this.linkRegister.TabIndex = 26;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Don\'t have account?";
            // 
            // buttonKembali
            // 
            this.buttonKembali.AutoSize = true;
            this.buttonKembali.BackColor = System.Drawing.Color.Tan;
            this.buttonKembali.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(630, 383);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(135, 48);
            this.buttonKembali.TabIndex = 25;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.AutoSize = true;
            this.buttonMasuk.BackColor = System.Drawing.Color.Tan;
            this.buttonMasuk.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasuk.Location = new System.Drawing.Point(30, 383);
            this.buttonMasuk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(107, 48);
            this.buttonMasuk.TabIndex = 24;
            this.buttonMasuk.Text = "Masuk";
            this.buttonMasuk.UseVisualStyleBackColor = false;
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(187, 257);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(524, 39);
            this.textBoxPassword.TabIndex = 23;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(32, 257);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(130, 36);
            this.labelPass.TabIndex = 22;
            this.labelPass.Text = "Password";
            // 
            // textBoxUname
            // 
            this.textBoxUname.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUname.Location = new System.Drawing.Point(187, 190);
            this.textBoxUname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(524, 39);
            this.textBoxUname.TabIndex = 21;
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(24, 193);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(138, 36);
            this.labelUname.TabIndex = 20;
            this.labelUname.Text = "Username";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::Celikoor_Kelompok6.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Location = new System.Drawing.Point(30, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLogo.TabIndex = 27;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(789, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonMasuk);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.labelUname);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonMasuk;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.Label labelUname;
    }
}