
namespace Celikoor_Kelompok6
{
    partial class FormTambahCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahCinema));
            this.pictureBoxGaris = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dateTimePickerTanggalDibuka = new System.Windows.Forms.DateTimePicker();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelTanggalDibuka = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.labelNamaCabang = new System.Windows.Forms.Label();
            this.textBoxNamaCabang = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.textBoxKota = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.labelJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGaris
            // 
            this.pictureBoxGaris.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxGaris.Location = new System.Drawing.Point(-5, -35);
            this.pictureBoxGaris.Name = "pictureBoxGaris";
            this.pictureBoxGaris.Size = new System.Drawing.Size(65, 149);
            this.pictureBoxGaris.TabIndex = 162;
            this.pictureBoxGaris.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Location = new System.Drawing.Point(37, -12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 126);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 161;
            this.pictureBoxLogo.TabStop = false;
            // 
            // dateTimePickerTanggalDibuka
            // 
            this.dateTimePickerTanggalDibuka.Font = new System.Drawing.Font("Trebuchet MS", 16.2F);
            this.dateTimePickerTanggalDibuka.Location = new System.Drawing.Point(282, 282);
            this.dateTimePickerTanggalDibuka.Name = "dateTimePickerTanggalDibuka";
            this.dateTimePickerTanggalDibuka.Size = new System.Drawing.Size(522, 39);
            this.dateTimePickerTanggalDibuka.TabIndex = 157;
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Tan;
            this.buttonKosongi.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(353, 424);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(163, 48);
            this.buttonKosongi.TabIndex = 156;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // labelTanggalDibuka
            // 
            this.labelTanggalDibuka.AutoSize = true;
            this.labelTanggalDibuka.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalDibuka.Location = new System.Drawing.Point(41, 282);
            this.labelTanggalDibuka.Name = "labelTanggalDibuka";
            this.labelTanggalDibuka.Size = new System.Drawing.Size(202, 36);
            this.labelTanggalDibuka.TabIndex = 151;
            this.labelTanggalDibuka.Text = "Tanggal Dibuka";
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(39, 354);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(71, 36);
            this.labelKota.TabIndex = 149;
            this.labelKota.Text = "Kota";
            // 
            // labelNamaCabang
            // 
            this.labelNamaCabang.AutoSize = true;
            this.labelNamaCabang.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaCabang.Location = new System.Drawing.Point(39, 142);
            this.labelNamaCabang.Name = "labelNamaCabang";
            this.labelNamaCabang.Size = new System.Drawing.Size(86, 36);
            this.labelNamaCabang.TabIndex = 148;
            this.labelNamaCabang.Text = "Nama";
            // 
            // textBoxNamaCabang
            // 
            this.textBoxNamaCabang.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaCabang.Location = new System.Drawing.Point(282, 142);
            this.textBoxNamaCabang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNamaCabang.Name = "textBoxNamaCabang";
            this.textBoxNamaCabang.Size = new System.Drawing.Size(522, 39);
            this.textBoxNamaCabang.TabIndex = 147;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(41, 212);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(104, 36);
            this.labelAlamat.TabIndex = 146;
            this.labelAlamat.Text = "Alamat";
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.Tan;
            this.buttonKembali.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(691, 424);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(168, 48);
            this.buttonKembali.TabIndex = 145;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Tan;
            this.buttonSimpan.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(27, 424);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(163, 48);
            this.buttonSimpan.TabIndex = 144;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // textBoxKota
            // 
            this.textBoxKota.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKota.Location = new System.Drawing.Point(282, 354);
            this.textBoxKota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKota.Name = "textBoxKota";
            this.textBoxKota.Size = new System.Drawing.Size(522, 39);
            this.textBoxKota.TabIndex = 143;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.Location = new System.Drawing.Point(282, 209);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(522, 39);
            this.textBoxAlamat.TabIndex = 141;
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Tan;
            this.labelJudul.Font = new System.Drawing.Font("Trebuchet MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(66, -2);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(864, 116);
            this.labelJudul.TabIndex = 139;
            this.labelJudul.Text = "Celikoor 21";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTambahCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(892, 518);
            this.Controls.Add(this.pictureBoxGaris);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dateTimePickerTanggalDibuka);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.labelTanggalDibuka);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.labelNamaCabang);
            this.Controls.Add(this.textBoxNamaCabang);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxKota);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.labelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubah Cinema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxGaris;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        public System.Windows.Forms.DateTimePicker dateTimePickerTanggalDibuka;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelTanggalDibuka;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Label labelNamaCabang;
        public System.Windows.Forms.TextBox textBoxNamaCabang;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonSimpan;
        public System.Windows.Forms.TextBox textBoxKota;
        public System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label labelJudul;
    }
}