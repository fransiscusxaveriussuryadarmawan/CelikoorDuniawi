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
    public partial class FormTambahJadwalFilms : Form
    {
        public FormTambahJadwalFilms()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeTerbaru = JadwalFilm.GenerateKode();

                //ciptakan objek yang akan ditambah
                JadwalFilm j = new JadwalFilm(kodeTerbaru, dateTimePickerTanggalLahir.Value, comboBoxJamPemutaran.Text);

                //panggil method TambahData di class konsumen
                JadwalFilm.TambahData(j);

                MessageBox.Show("Data Jadwal Film telah tersimpan.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
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
