
namespace Celikoor_Kelompok6
{
    partial class FormRegister
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.labelUname = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(323, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 39);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.Tan;
            this.buttonKembali.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(617, 403);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(168, 48);
            this.buttonKembali.TabIndex = 24;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.BackColor = System.Drawing.Color.Tan;
            this.buttonDaftar.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDaftar.Location = new System.Drawing.Point(4, 403);
            this.buttonDaftar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(163, 48);
            this.buttonDaftar.TabIndex = 23;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = false;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(323, 281);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(316, 39);
            this.textBoxPassword.TabIndex = 22;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(128, 284);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(130, 36);
            this.labelPass.TabIndex = 21;
            this.labelPass.Text = "Password";
            this.labelPass.Click += new System.EventHandler(this.labelPass_Click);
            // 
            // textBoxUname
            // 
            this.textBoxUname.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUname.Location = new System.Drawing.Point(323, 213);
            this.textBoxUname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(316, 39);
            this.textBoxUname.TabIndex = 20;
            this.textBoxUname.TextChanged += new System.EventHandler(this.textBoxUname_TextChanged);
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(128, 216);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(146, 36);
            this.labelUname.TabIndex = 19;
            this.labelUname.Text = "Username ";
            this.labelUname.Click += new System.EventHandler(this.labelUname_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Tan;
            this.labelJudul.Font = new System.Drawing.Font("Trebuchet MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(-4, 2);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(801, 116);
            this.labelJudul.TabIndex = 18;
            this.labelJudul.Text = "Celikoor 21";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJudul.Click += new System.EventHandler(this.labelJudul_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonDaftar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.labelUname);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.Label labelJudul;
    }
}