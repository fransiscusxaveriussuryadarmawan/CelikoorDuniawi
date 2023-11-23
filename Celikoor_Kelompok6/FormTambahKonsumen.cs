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
    public partial class FormTambahKonsumen : Form
    {
        public FormTambahKonsumen()
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
            textBoxNama.Focus();
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

        private void FormTambahKonsumen_Load(object sender, EventArgs e)
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

        private void buttonSimpan_Click(object sender, EventArgs e)
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

                string kodeTerbaru = Konsumen.GenerateKode();

                //ciptakan objek yang akan ditambah
                Konsumen k = new Konsumen(kodeTerbaru, textBoxNama.Text, textBoxEmail.Text, textBoxNomorHP.Text, gender,
                    dateTimePickerTanggalLahir.Value, double.Parse(textBoxSaldo.Text), textBoxUsername.Text, textBoxPassword.Text);

                //panggil method TambahData di class kategori
                Konsumen.TambahData(k);

                MessageBox.Show("Data konsumen telah tersimpan.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarKonsumen formDaftarKonsumen = (FormDaftarKonsumen)this.Owner;
            formDaftarKonsumen.FormDaftarKonsumen_Load(buttonKembali, e);

            this.Close();
        }
    }
}
