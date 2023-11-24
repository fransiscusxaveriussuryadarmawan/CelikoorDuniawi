
namespace Celikoor_Kelompok6
{
    partial class FormDaftarPegawai
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
            this.panelDaftarPegawai = new System.Windows.Forms.Panel();
            this.textBoxKriteria = new System.Windows.Forms.TextBox();
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.labelCariBerdasarkan = new System.Windows.Forms.Label();
            this.labelDaftarPegawai = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewDaftarPegawai = new System.Windows.Forms.DataGridView();
            this.panelDaftarPegawai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDaftarPegawai
            // 
            this.panelDaftarPegawai.BackColor = System.Drawing.Color.Lavender;
            this.panelDaftarPegawai.Controls.Add(this.textBoxKriteria);
            this.panelDaftarPegawai.Controls.Add(this.comboBoxKriteria);
            this.panelDaftarPegawai.Controls.Add(this.labelCariBerdasarkan);
            this.panelDaftarPegawai.Location = new System.Drawing.Point(15, 83);
            this.panelDaftarPegawai.Name = "panelDaftarPegawai";
            this.panelDaftarPegawai.Size = new System.Drawing.Size(771, 71);
            this.panelDaftarPegawai.TabIndex = 16;
            // 
            // textBoxKriteria
            // 
            this.textBoxKriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKriteria.Location = new System.Drawing.Point(458, 23);
            this.textBoxKriteria.Name = "textBoxKriteria";
            this.textBoxKriteria.Size = new System.Drawing.Size(295, 28);
            this.textBoxKriteria.TabIndex = 2;
            this.textBoxKriteria.TextChanged += new System.EventHandler(this.textBoxKriteria_TextChanged);
            // 
            // comboBoxKriteria
            // 
            this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKriteria.FormattingEnabled = true;
            this.comboBoxKriteria.Items.AddRange(new object[] {
            "Id",
            "Nama",
            "Email",
            "Username",
            "Role"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(211, 22);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(230, 30);
            this.comboBoxKriteria.TabIndex = 1;
            // 
            // labelCariBerdasarkan
            // 
            this.labelCariBerdasarkan.AutoSize = true;
            this.labelCariBerdasarkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariBerdasarkan.Location = new System.Drawing.Point(12, 22);
            this.labelCariBerdasarkan.Name = "labelCariBerdasarkan";
            this.labelCariBerdasarkan.Size = new System.Drawing.Size(193, 25);
            this.labelCariBerdasarkan.TabIndex = 0;
            this.labelCariBerdasarkan.Text = "Cari Berdasarkan :";
            // 
            // labelDaftarPegawai
            // 
            this.labelDaftarPegawai.BackColor = System.Drawing.Color.Tan;
            this.labelDaftarPegawai.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarPegawai.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDaftarPegawai.Location = new System.Drawing.Point(15, 11);
            this.labelDaftarPegawai.Name = "labelDaftarPegawai";
            this.labelDaftarPegawai.Size = new System.Drawing.Size(771, 57);
            this.labelDaftarPegawai.TabIndex = 15;
            this.labelDaftarPegawai.Text = "DAFTAR PEGAWAI";
            this.labelDaftarPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Tan;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKeluar.Location = new System.Drawing.Point(618, 390);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(168, 50);
            this.buttonKeluar.TabIndex = 19;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Tan;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonTambah.Location = new System.Drawing.Point(15, 390);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(168, 50);
            this.buttonTambah.TabIndex = 18;
            this.buttonTambah.Text = "&TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewDaftarPegawai
            // 
            this.dataGridViewDaftarPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPegawai.Location = new System.Drawing.Point(15, 169);
            this.dataGridViewDaftarPegawai.Name = "dataGridViewDaftarPegawai";
            this.dataGridViewDaftarPegawai.RowHeadersWidth = 51;
            this.dataGridViewDaftarPegawai.RowTemplate.Height = 24;
            this.dataGridViewDaftarPegawai.Size = new System.Drawing.Size(771, 212);
            this.dataGridViewDaftarPegawai.TabIndex = 17;
            this.dataGridViewDaftarPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarPegawai_CellContentClick);
            // 
            // FormDaftarPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDaftarPegawai);
            this.Controls.Add(this.labelDaftarPegawai);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewDaftarPegawai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Pegawai";
            this.Load += new System.EventHandler(this.FormDaftarPegawai_Load);
            this.panelDaftarPegawai.ResumeLayout(false);
            this.panelDaftarPegawai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPegawai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDaftarPegawai;
        private System.Windows.Forms.TextBox textBoxKriteria;
        private System.Windows.Forms.ComboBox comboBoxKriteria;
        private System.Windows.Forms.Label labelCariBerdasarkan;
        private System.Windows.Forms.Label labelDaftarPegawai;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPegawai;
    }
}