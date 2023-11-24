
namespace Celikoor_Kelompok6
{
    partial class FormDaftarKelompok
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
            this.labelDaftarCinema = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewDaftarKelompok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKelompok)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDaftarCinema
            // 
            this.labelDaftarCinema.BackColor = System.Drawing.Color.Tan;
            this.labelDaftarCinema.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarCinema.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDaftarCinema.Location = new System.Drawing.Point(15, 11);
            this.labelDaftarCinema.Name = "labelDaftarCinema";
            this.labelDaftarCinema.Size = new System.Drawing.Size(771, 57);
            this.labelDaftarCinema.TabIndex = 20;
            this.labelDaftarCinema.Text = "DAFTAR KELOMPOK";
            this.labelDaftarCinema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Tan;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKeluar.Location = new System.Drawing.Point(618, 390);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(168, 50);
            this.buttonKeluar.TabIndex = 23;
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
            this.buttonTambah.TabIndex = 22;
            this.buttonTambah.Text = "&TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewDaftarKelompok
            // 
            this.dataGridViewDaftarKelompok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarKelompok.Location = new System.Drawing.Point(15, 84);
            this.dataGridViewDaftarKelompok.Name = "dataGridViewDaftarKelompok";
            this.dataGridViewDaftarKelompok.RowHeadersWidth = 51;
            this.dataGridViewDaftarKelompok.RowTemplate.Height = 24;
            this.dataGridViewDaftarKelompok.Size = new System.Drawing.Size(771, 297);
            this.dataGridViewDaftarKelompok.TabIndex = 21;
            this.dataGridViewDaftarKelompok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarKelompok_CellContentClick);
            // 
            // FormDaftarKelompok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDaftarCinema);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewDaftarKelompok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarKelompok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Kelompok";
            this.Load += new System.EventHandler(this.FormDaftarKelompok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKelompok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDaftarCinema;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewDaftarKelompok;
    }
}