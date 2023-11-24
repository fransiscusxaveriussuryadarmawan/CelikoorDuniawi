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
    public partial class FormUbahKonsumen : Form
    {
        public Konsumen konsumenDipilih;

        public FormUbahKonsumen()
        {
            InitializeComponent();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxEmail.Text = "";
            textBoxNomorHP.Text = "";
            radioButtonLaki.Checked = false;
            radioButtonWanita.Checked = false;
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            textBoxSaldo.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUlangPassword.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarKonsumen formDaftarKonsumen = (FormDaftarKonsumen)this.Owner;
            formDaftarKonsumen.FormDaftarKonsumen_Load(buttonKembali, e);

            this.Close();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxUlangPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxUlangPassword.PasswordChar = '*';
            }
        }

        private void FormUbahKonsumen_Load(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxUlangPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxUlangPassword.PasswordChar = '*';
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxUlangPassword.Text)
            {
                MessageBox.Show("Password tidak sama !");
            }

            else
            {
                try
                {
                    string gender = "";

                    if (radioButtonLaki.Checked)
                    {
                        gender = "L";
                    }

                    else if (radioButtonWanita.Checked)
                    {
                        gender = "P";
                    }

                    konsumenDipilih.Nama = textBoxNama.Text;
                    konsumenDipilih.Email = textBoxEmail.Text;
                    konsumenDipilih.NoHP = textBoxNomorHP.Text;
                    konsumenDipilih.Gender = gender;
                    konsumenDipilih.TglLahir = dateTimePickerTanggalLahir.Value;
                    konsumenDipilih.Saldo = double.Parse(textBoxSaldo.Text);
                    konsumenDipilih.Username = textBoxUsername.Text;
                    konsumenDipilih.Password = textBoxPassword.Text;

                    //panggil method UbahData di class Konsumen
                    Konsumen.UbahData(konsumenDipilih);

                    MessageBox.Show("Data konsumen telah diubah.", "Info");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
                }
            }
        }
    }
}
