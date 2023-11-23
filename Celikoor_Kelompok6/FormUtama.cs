using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Kelompok6
{
    public partial class FormUtama : Form
    {
        //public Pegawai pengguna;
        //public Pegawai pengguna;
        

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            try
            {
                Koneksi koneksi = new Koneksi();
                MessageBox.Show("Koneksi Database Berhasil", "Informasi");

                FormLogin frmLogin = new FormLogin();
                frmLogin.Owner = this;
                this.Hide();
                frmLogin.ShowDialog();

                //if (formLogin.ShowDialog() == DialogResult.OK) //jika login sukses
                //{
                //    labelKodePegawai.Text = pengguna.KodePegawai;
                //    labelNamaPegawai.Text = pengguna.Nama;
                //}
                //else //jika login gagal
                //{
                //    MessageBox.Show("Gagal Login");
                //    Application.Exit();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex.Message);
            } 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AturMenu(string peran)
        {
            if(peran == "konsumens")
            {
                akunToolStripMenuItem.Enabled = true;
                masterToolStripMenuItem.Enabled = false;
                laporanToolStripMenuItem.Enabled = false;
                pemesananTiketToolStripMenuItem.Enabled = true;
                penjualanTiketToolStripMenuItem.Enabled = false;
            }
            else if(peran == "pegawais")
            {
                akunToolStripMenuItem.Enabled = true;
                masterToolStripMenuItem.Enabled = true;
                laporanToolStripMenuItem.Enabled = true;
                pemesananTiketToolStripMenuItem.Enabled = false;
                penjualanTiketToolStripMenuItem.Enabled = true;
            }
        }
    }
}
