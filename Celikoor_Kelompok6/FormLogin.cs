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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                //create objek Koneksi
                Koneksi koneksi = new Koneksi();

                // username dan password
                Konsumen k = Konsumen.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                Pegawai p = Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                if (!(k is null)) //jika ditemukan konsumen dengan username dan password tersebut
                {
                    FormUtama formUtama = (FormUtama)this.Owner;
                    formUtama.userKonsumen = k;

                    MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi");

                    //panggil method hak akses
                    string peran = "konsumens";
                    formUtama.AturMenu(peran);

                    this.DialogResult = DialogResult.OK;
                    formUtama.Visible = true;
                    this.Close(); //tutup FormLogin
                }

                else if (!(p is null)) //jika ditemukan pegawai dengan username dan password tersebut
                {
                    FormUtama formUtama = (FormUtama)this.Owner;
                    formUtama.userPegawai = p;

                    MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi");

                    //panggil method hak akses
                    string peran = "pegawais";
                    formUtama.AturMenu(peran);

                    this.DialogResult = DialogResult.OK;
                    formUtama.Visible = true;
                    this.Close(); //tutup FormLogin
                }

                else
                {
                    MessageBox.Show(this, "Username tidak ditemukan atau password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Owner = this;
            this.Hide();
            formRegister.ShowDialog();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
