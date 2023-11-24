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
    public partial class FormTambahAktors : Form
    {
        public FormTambahAktors()
        {
            InitializeComponent();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxNegaraAsal.Text = "";
            radioButtonLaki.Checked = false;
            radioButtonWanita.Checked = false;
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            textBoxNama.Focus();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarAktors formDaftarAktor = (FormDaftarAktors)this.Owner;
            formDaftarAktor.FormDaftarAktors_Load(buttonKembali, e);

            this.Close();
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

                string kodeTerbaru = Aktor.GenerateKode();

                //ciptakan objek yang akan ditambah
                Aktor a = new Aktor(kodeTerbaru, textBoxNama.Text, dateTimePickerTanggalLahir.Value, gender,
                    textBoxNegaraAsal.Text);

                //panggil method TambahData di class konsumen
                Aktor.TambahData(a);

                MessageBox.Show("Data Aktor telah tersimpan.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
    }
}
