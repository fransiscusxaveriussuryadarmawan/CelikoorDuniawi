
namespace Celikoor_Kelompok6
{
    partial class FormDaftarKonsumen
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
            this.panelDaftarKonsumen = new System.Windows.Forms.Panel();
            this.textBoxKriteria = new System.Windows.Forms.TextBox();
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.labelCariBerdasarkan = new System.Windows.Forms.Label();
            this.labelDaftarKonsumen = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewDaftarKonsumen = new System.Windows.Forms.DataGridView();
            this.panelDaftarKonsumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKonsumen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDaftarKonsumen
            // 
            this.panelDaftarKonsumen.BackColor = System.Drawing.Color.Lavender;
            this.panelDaftarKonsumen.Controls.Add(this.textBoxKriteria);
            this.panelDaftarKonsumen.Controls.Add(this.comboBoxKriteria);
            this.panelDaftarKonsumen.Controls.Add(this.labelCariBerdasarkan);
            this.panelDaftarKonsumen.Location = new System.Drawing.Point(15, 83);
            this.panelDaftarKonsumen.Name = "panelDaftarKonsumen";
            this.panelDaftarKonsumen.Size = new System.Drawing.Size(771, 71);
            this.panelDaftarKonsumen.TabIndex = 11;
            this.panelDaftarKonsumen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDaftarKonsumen_Paint);
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
            "Nomor HP",
            "Gender",
            "Tanggal Lahir",
            "Saldo ",
            "Username"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(211, 22);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(230, 30);
            this.comboBoxKriteria.TabIndex = 1;
            this.comboBoxKriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxKriteria_SelectedIndexChanged);
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
            this.labelCariBerdasarkan.Click += new System.EventHandler(this.labelCariBerdasarkan_Click);
            // 
            // labelDaftarKonsumen
            // 
            this.labelDaftarKonsumen.BackColor = System.Drawing.Color.Tan;
            this.labelDaftarKonsumen.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarKonsumen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDaftarKonsumen.Location = new System.Drawing.Point(15, 11);
            this.labelDaftarKonsumen.Name = "labelDaftarKonsumen";
            this.labelDaftarKonsumen.Size = new System.Drawing.Size(771, 57);
            this.labelDaftarKonsumen.TabIndex = 10;
            this.labelDaftarKonsumen.Text = "DAFTAR KONSUMEN";
            this.labelDaftarKonsumen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDaftarKonsumen.Click += new System.EventHandler(this.labelDaftarKonsumen_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Tan;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKeluar.Location = new System.Drawing.Point(618, 390);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(168, 50);
            this.buttonKeluar.TabIndex = 14;
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
            this.buttonTambah.TabIndex = 13;
            this.buttonTambah.Text = "&TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewDaftarKonsumen
            // 
            this.dataGridViewDaftarKonsumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarKonsumen.Location = new System.Drawing.Point(15, 169);
            this.dataGridViewDaftarKonsumen.Name = "dataGridViewDaftarKonsumen";
            this.dataGridViewDaftarKonsumen.RowHeadersWidth = 51;
            this.dataGridViewDaftarKonsumen.RowTemplate.Height = 24;
            this.dataGridViewDaftarKonsumen.Size = new System.Drawing.Size(771, 212);
            this.dataGridViewDaftarKonsumen.TabIndex = 12;
            this.dataGridViewDaftarKonsumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarKonsumen_CellContentClick);
            // 
            // FormDaftarKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDaftarKonsumen);
            this.Controls.Add(this.labelDaftarKonsumen);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewDaftarKonsumen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarKonsumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Konsumen";
            this.Load += new System.EventHandler(this.FormDaftarKonsumen_Load);
            this.panelDaftarKonsumen.ResumeLayout(false);
            this.panelDaftarKonsumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKonsumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDaftarKonsumen;
        private System.Windows.Forms.TextBox textBoxKriteria;
        private System.Windows.Forms.ComboBox comboBoxKriteria;
        private System.Windows.Forms.Label labelCariBerdasarkan;
        private System.Windows.Forms.Label labelDaftarKonsumen;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewDaftarKonsumen;
    }
}