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
    public partial class FormUbahAktors : Form
    {
        public Aktor aktorDipilih;

        public FormUbahAktors()
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

                aktorDipilih.Nama = textBoxNama.Text;
                aktorDipilih.TanggalLahir = dateTimePickerTanggalLahir.Value;
                aktorDipilih.Gender = gender;
                aktorDipilih.NegaraAsal = textBoxNegaraAsal.Text;

                //panggil method UbahData di class Konsumen
                Aktor.UbahData(aktorDipilih);

                MessageBox.Show("Data aktor telah diubah.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
    }
}
