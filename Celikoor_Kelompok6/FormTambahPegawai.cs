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
    public partial class FormTambahPegawai : Form
    {
        public FormTambahPegawai()
        {
            InitializeComponent();
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

        private void FormTambahPegawai_Load(object sender, EventArgs e)
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

            comboBoxRoles.SelectedIndex = 0;
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUlangPassword.Text = "";
            comboBoxRoles.SelectedIndex = -1;
            textBoxNama.Focus();
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
                    string jabatan = comboBoxRoles.SelectedItem.ToString();

                    string kodeTerbaru = Pegawai.GenerateKode();

                    //ciptakan objek yang akan ditambah
                    Pegawai p = new Pegawai(kodeTerbaru, textBoxNama.Text, textBoxEmail.Text, textBoxUsername.Text,
                        textBoxPassword.Text, jabatan);

                    //panggil method TambahData di class pegawai
                    Pegawai.TambahData(p);

                    MessageBox.Show("Data pegawai telah tersimpan.", "Info");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
                }
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai formDaftarPegawai = (FormDaftarPegawai)this.Owner;
            formDaftarPegawai.FormDaftarPegawai_Load(buttonKembali, e);

            this.Close();
        }
    }
}
