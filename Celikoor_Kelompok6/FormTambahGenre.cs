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
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxDeskripsi.Text = "";
            textBoxNamaGenre.Text = "";
            textBoxDeskripsi.Focus();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarGenre formDaftarGenre = (FormDaftarGenre)this.Owner;
            formDaftarGenre.FormDaftarGenre_Load(buttonKembali, e);

            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeTerbaru = Genre.GenerateKode();

                //ciptakan objek yang akan ditambah
                Genre g = new Genre(kodeTerbaru, textBoxNamaGenre.Text, textBoxDeskripsi.Text);

                //panggil method TambahData di class genre
                Genre.TambahData(g);

                MessageBox.Show("Data genre telah tersimpan.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
    }
}
