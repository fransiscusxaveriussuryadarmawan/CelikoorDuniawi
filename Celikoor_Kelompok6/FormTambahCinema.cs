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
    public partial class FormTambahCinema : Form
    {
        public Cinema cinemaDipilih;

        public FormTambahCinema()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeTerbaru = Cinema.GenerateKode();

                //ciptakan objek yang akan ditambah
                Cinema c = new Cinema(kodeTerbaru, textBoxNamaCabang.Text, textBoxAlamat.Text, 
                    dateTimePickerTanggalDibuka.Value, textBoxKota.Text);

                //panggil method TambahData di class konsumen
                Cinema.TambahData(c);

                MessageBox.Show("Data cinema telah tersimpan.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaCabang.Text = "";
            textBoxAlamat.Text = "";
            textBoxKota.Text = "";
            dateTimePickerTanggalDibuka.Value = DateTime.Now;
            textBoxNamaCabang.Focus();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarCinema formDaftarCinema = (FormDaftarCinema)this.Owner;
            formDaftarCinema.FormDaftarCinema_Load(buttonKembali, e);

            this.Close();
        }
    }
}
