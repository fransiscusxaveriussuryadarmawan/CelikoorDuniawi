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
        public Pegawai userPegawai;
        public Konsumen userKonsumen;

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

                if (frmLogin.ShowDialog() == DialogResult.OK) //jika login sukses
                {
                    MessageBox.Show("Berhasil Login");

                    if (userKonsumen != null)
                    {
                        labelNama.Text = userKonsumen.Nama;
                    }

                    else if (userPegawai != null)
                    {
                        labelNama.Text = userPegawai.Nama;
                    }
                    
                }
                else //jika login gagal
                {
                    MessageBox.Show("Gagal Login");
                    Application.Exit();
                }
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

        public void AturMenu(string peran)
        {
            if(peran == "konsumens")
            {
                transaksiToolStripMenuItem.Visible = true;
                pemesananTiketToolStripMenuItem.Visible = true;
            }

            else if(peran == "pegawais")
            {
                if (userPegawai.Role.ToString() == "ADMIN")
                {
                    masterToolStripMenuItem.Visible = true;
                    cinemaToolStripMenuItem.Visible = true;
                    studioToolStripMenuItem.Visible = true;
                    jenisStudioToolStripMenuItem.Visible = true;
                    genreToolStripMenuItem.Visible = true;
                    kelompokToolStripMenuItem.Visible = true;
                    aktorsToolStripMenuItem.Visible = true;
                    pegawaiToolStripMenuItem1.Visible = true;
                    konsumenToolStripMenuItem1.Visible = true;

                    transaksiToolStripMenuItem.Visible = true;
                    penjualanTiketToolStripMenuItem.Visible = true;

                    laporanToolStripMenuItem.Visible = true;
                    masterToolStripMenuItem1.Visible = true;
                    cinemaToolStripMenuItem1.Visible = true;
                    studioToolStripMenuItem1.Visible = true;
                    jenisStudioToolStripMenuItem1.Visible = true;
                    genreToolStripMenuItem1.Visible = true;
                    kelompokToolStripMenuItem1.Visible = true;
                    aktorsToolStripMenuItem1.Visible = true;
                    pegawaiToolStripMenuItem.Visible = true;
                    konsumenToolStripMenuItem.Visible = true;

                    tansaksiToolStripMenuItem.Visible = true;
                    pemesananTiketToolStripMenuItem1.Visible = true;
                    penjualanTiketToolStripMenuItem1.Visible = true;
                }

                else if (userPegawai.Role.ToString() == "KASIR")
                {
                    transaksiToolStripMenuItem.Visible = true;
                    penjualanTiketToolStripMenuItem.Visible = true;

                    laporanToolStripMenuItem.Visible = true;
                    masterToolStripMenuItem1.Visible = true;
                    cinemaToolStripMenuItem1.Visible = true;
                    studioToolStripMenuItem1.Visible = true;
                    jenisStudioToolStripMenuItem1.Visible = true;
                    genreToolStripMenuItem1.Visible = true;
                    kelompokToolStripMenuItem1.Visible = true;
                    aktorsToolStripMenuItem1.Visible = true;
                    pegawaiToolStripMenuItem.Visible = true;
                    konsumenToolStripMenuItem.Visible = true;

                    tansaksiToolStripMenuItem.Visible = true;
                    pemesananTiketToolStripMenuItem1.Visible = true;
                    penjualanTiketToolStripMenuItem1.Visible = true;
                }

                else if (userPegawai.Role.ToString() == "OPERATOR")
                {
                    transaksiToolStripMenuItem.Visible = true;
                    pemesananTiketToolStripMenuItem.Visible = true;
                    penjualanTiketToolStripMenuItem.Visible = true;

                    laporanToolStripMenuItem.Visible = true;
                    masterToolStripMenuItem1.Visible = true;
                    cinemaToolStripMenuItem1.Visible = true;
                    studioToolStripMenuItem1.Visible = true;
                    jenisStudioToolStripMenuItem1.Visible = true;
                    genreToolStripMenuItem1.Visible = true;
                    kelompokToolStripMenuItem1.Visible = true;
                    aktorsToolStripMenuItem1.Visible = true;
                    pegawaiToolStripMenuItem.Visible = true;
                    konsumenToolStripMenuItem.Visible = true;

                    tansaksiToolStripMenuItem.Visible = true;
                    pemesananTiketToolStripMenuItem1.Visible = true;
                    penjualanTiketToolStripMenuItem1.Visible = true;
                }
            }
        }

        private void checkProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormCheckProfile"];

            if (form == null)
            {
                FormCheckProfile formCheckProfile = new FormCheckProfile();
                formCheckProfile.MdiParent = this;

                if (userKonsumen != null)
                {
                    formCheckProfile.userCheckKonsumen = this.userKonsumen;
                }

                else if (userPegawai != null)
                {
                    formCheckProfile.userCheckPegawai = this.userPegawai;
                }

                formCheckProfile.Show();

            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormChangePassword"];

            if (form == null)
            {
                FormChangePassword formChangePassword = new FormChangePassword();
                formChangePassword.MdiParent = this;
                formChangePassword.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarCinema"];

            if (form == null)
            {
                FormDaftarCinema formDaftarCinema = new FormDaftarCinema();
                formDaftarCinema.MdiParent = this;
                formDaftarCinema.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarStudio"];

            if (form == null)
            {
                FormDaftarStudio formDaftarStudio = new FormDaftarStudio();
                formDaftarStudio.MdiParent = this;
                formDaftarStudio.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void jenisStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarJenisStudio"];

            if (form == null)
            {
                FormDaftarJenisStudio formDaftarJenisStudio = new FormDaftarJenisStudio();
                formDaftarJenisStudio.MdiParent = this;
                formDaftarJenisStudio.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarGenre"];

            if (form == null)
            {
                FormDaftarGenre formDaftarGenre = new FormDaftarGenre();
                formDaftarGenre.MdiParent = this;
                formDaftarGenre.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void kelompokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKelompok"];

            if (form == null)
            {
                FormDaftarKelompok formDaftarKelompok = new FormDaftarKelompok();
                formDaftarKelompok.MdiParent = this;
                formDaftarKelompok.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void aktorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarAktors"];

            if (form == null)
            {
                FormDaftarAktors formDaftarAktors = new FormDaftarAktors();
                formDaftarAktors.MdiParent = this;
                formDaftarAktors.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pegawaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPegawai"];

            if (form == null)
            {
                FormDaftarPegawai formDaftarPegawai = new FormDaftarPegawai();
                formDaftarPegawai.MdiParent = this;
                formDaftarPegawai.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void konsumenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKonsumen"];

            if (form == null)
            {
                FormDaftarKonsumen formDaftarKonsumen = new FormDaftarKonsumen();
                formDaftarKonsumen.MdiParent = this;
                formDaftarKonsumen.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pemesananTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPemesananTiket"];

            if (form == null)
            {
                FormPemesananTiket formPemesananTiket = new FormPemesananTiket();
                formPemesananTiket.MdiParent = this;
                formPemesananTiket.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void penjualanTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPenjualanTiket"];

            if (form == null)
            {
                FormPenjualanTiket formPenjualanTiket = new FormPenjualanTiket();
                formPenjualanTiket.MdiParent = this;
                formPenjualanTiket.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void cinemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void studioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void jenisStudioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void genreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void kelompokToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void aktorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void pemesananTiketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void penjualanTiketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form form = Application.OpenForms["FormChangePassword"];

            //if (form == null)
            //{
            //    FormChangePassword formChangePassword = new FormChangePassword();
            //    formChangePassword.MdiParent = this;
            //    formChangePassword.Show();
            //}
            //else
            //{
            //    form.Show();
            //    form.BringToFront();
            //}
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelNama.Text = "Nama";
            userPegawai = null;
            userKonsumen = null;

            FormUtama_Load(this, e);
        }
    }
}
