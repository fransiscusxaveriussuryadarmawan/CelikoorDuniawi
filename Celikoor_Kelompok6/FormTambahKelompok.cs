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
    public partial class FormTambahKelompok : Form
    {
        public Kelompok kelompokDipilih;

        public FormTambahKelompok()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeTerbaru = Kelompok.GenerateKode();

                //ciptakan objek yang akan ditambah
                Kelompok k = new Kelompok(kodeTerbaru, textBoxNamaKelompok.Text);

                //panggil method TambahData di class konsumen
                Kelompok.TambahData(k);

                MessageBox.Show("Data kelompok telah tersimpan.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaKelompok.Text = "";
            textBoxNamaKelompok.Focus();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarKelompok formDaftarKelompok = (FormDaftarKelompok)this.Owner;
            formDaftarKelompok.FormDaftarKelompok_Load(buttonKembali, e);

            this.Close();
        }
    }
}
