namespace Celikoor_Kelompok6_UI
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelUname = new System.Windows.Forms.Label();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.linkFP = new System.Windows.Forms.LinkLabel();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Aquamarine;
            this.labelJudul.Font = new System.Drawing.Font("Trebuchet MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(-1, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(801, 116);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Celikoor 21";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(121, 137);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(144, 35);
            this.labelUname.TabIndex = 1;
            this.labelUname.Text = "Username ";
            // 
            // textBoxUname
            // 
            this.textBoxUname.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUname.Location = new System.Drawing.Point(256, 137);
            this.textBoxUname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(316, 39);
            this.textBoxUname.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(256, 209);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(316, 39);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(125, 209);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(125, 35);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Password";
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonMasuk.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasuk.Location = new System.Drawing.Point(256, 276);
            this.buttonMasuk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(99, 48);
            this.buttonMasuk.TabIndex = 5;
            this.buttonMasuk.Text = "Masuk";
            this.buttonMasuk.UseVisualStyleBackColor = false;
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonKembali.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(666, 389);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(116, 48);
            this.buttonKembali.TabIndex = 6;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            // 
            // linkFP
            // 
            this.linkFP.AutoSize = true;
            this.linkFP.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkFP.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkFP.Location = new System.Drawing.Point(252, 340);
            this.linkFP.Name = "linkFP";
            this.linkFP.Size = new System.Drawing.Size(132, 22);
            this.linkFP.TabIndex = 7;
            this.linkFP.TabStop = true;
            this.linkFP.Text = "Forgot Password?";
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkRegister.Location = new System.Drawing.Point(420, 340);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(152, 22);
            this.linkRegister.TabIndex = 8;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Don\'t have account?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 443);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.linkFP);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonMasuk);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.labelUname);
            this.Controls.Add(this.labelJudul);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonMasuk;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.LinkLabel linkFP;
        private System.Windows.Forms.LinkLabel linkRegister;
    }
}