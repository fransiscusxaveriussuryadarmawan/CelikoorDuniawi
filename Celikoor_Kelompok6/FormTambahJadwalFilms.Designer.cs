
namespace Celikoor_Kelompok6
{
    partial class FormTambahJadwalFilms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahJadwalFilms));
            this.labelJamPemutaran = new System.Windows.Forms.Label();
            this.pictureBoxGaris = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.labelJudul = new System.Windows.Forms.Label();
            this.comboBoxJamPemutaran = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTanggalLahir = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJamPemutaran
            // 
            this.labelJamPemutaran.AutoSize = true;
            this.labelJamPemutaran.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJamPemutaran.Location = new System.Drawing.Point(32, 216);
            this.labelJamPemutaran.Name = "labelJamPemutaran";
            this.labelJamPemutaran.Size = new System.Drawing.Size(209, 36);
            this.labelJamPemutaran.TabIndex = 196;
            this.labelJamPemutaran.Text = "Jam Pemutaran";
            // 
            // pictureBoxGaris
            // 
            this.pictureBoxGaris.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxGaris.Location = new System.Drawing.Point(-12, -34);
            this.pictureBoxGaris.Name = "pictureBoxGaris";
            this.pictureBoxGaris.Size = new System.Drawing.Size(65, 149);
            this.pictureBoxGaris.TabIndex = 194;
            this.pictureBoxGaris.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Location = new System.Drawing.Point(30, -11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 126);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 193;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Tan;
            this.buttonKosongi.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.Location = new System.Drawing.Point(344, 303);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(163, 48);
            this.buttonKosongi.TabIndex = 192;
            this.buttonKosongi.Text = "Kosongi";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(32, 143);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(109, 36);
            this.labelTanggal.TabIndex = 191;
            this.labelTanggal.Text = "Tanggal";
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.Tan;
            this.buttonKembali.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(682, 303);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(168, 48);
            this.buttonKembali.TabIndex = 189;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Tan;
            this.buttonSimpan.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(18, 303);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(163, 48);
            this.buttonSimpan.TabIndex = 188;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Tan;
            this.labelJudul.Font = new System.Drawing.Font("Trebuchet MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(59, -1);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(864, 116);
            this.labelJudul.TabIndex = 187;
            this.labelJudul.Text = "Celikoor 21";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxJamPemutaran
            // 
            this.comboBoxJamPemutaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJamPemutaran.Font = new System.Drawing.Font("Trebuchet MS", 16.2F);
            this.comboBoxJamPemutaran.ForeColor = System.Drawing.Color.Black;
            this.comboBoxJamPemutaran.FormattingEnabled = true;
            this.comboBoxJamPemutaran.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.comboBoxJamPemutaran.Location = new System.Drawing.Point(310, 213);
            this.comboBoxJamPemutaran.Name = "comboBoxJamPemutaran";
            this.comboBoxJamPemutaran.Size = new System.Drawing.Size(522, 43);
            this.comboBoxJamPemutaran.TabIndex = 198;
            // 
            // dateTimePickerTanggalLahir
            // 
            this.dateTimePickerTanggalLahir.Font = new System.Drawing.Font("Trebuchet MS", 16.2F);
            this.dateTimePickerTanggalLahir.Location = new System.Drawing.Point(310, 143);
            this.dateTimePickerTanggalLahir.Name = "dateTimePickerTanggalLahir";
            this.dateTimePickerTanggalLahir.Size = new System.Drawing.Size(522, 39);
            this.dateTimePickerTanggalLahir.TabIndex = 197;
            // 
            // FormTambahJadwalFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(879, 391);
            this.Controls.Add(this.comboBoxJamPemutaran);
            this.Controls.Add(this.dateTimePickerTanggalLahir);
            this.Controls.Add(this.labelJamPemutaran);
            this.Controls.Add(this.pictureBoxGaris);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahJadwalFilms";
            this.Text = "Tambah Jadwal Films";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJamPemutaran;
        private System.Windows.Forms.PictureBox pictureBoxGaris;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelJudul;
        public System.Windows.Forms.ComboBox comboBoxJamPemutaran;
        public System.Windows.Forms.DateTimePicker dateTimePickerTanggalLahir;
    }
}