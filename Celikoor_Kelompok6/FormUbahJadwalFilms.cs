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
    public partial class FormUbahJadwalFilms : Form
    {
        public JadwalFilm jadwalFilmDipilih;

        public FormUbahJadwalFilms()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                jadwalFilmDipilih.TglDate = dateTimePickerTanggalLahir.Value;
                jadwalFilmDipilih.JamPemutaran = comboBoxJamPemutaran.Text;
                //panggil method UbahData di class Konsumen
                JadwalFilm.UbahData(jadwalFilmDipilih);

                MessageBox.Show("Data Jadwal Film telah diubah.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            comboBoxJamPemutaran.SelectedIndex = -1;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarJadwalFilms formDaftarJadwalFilms = (FormDaftarJadwalFilms)this.Owner;
            formDaftarJadwalFilms.FormDaftarJadwalFilms_Load(buttonKembali, e);

            this.Close();
        }
    }
}
