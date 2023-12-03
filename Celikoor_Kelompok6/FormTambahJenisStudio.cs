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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }
        
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string kodeTerbaru = JenisStudio.GenerateKode();

                //ciptakan objek yang akan ditambah
                JenisStudio js = new JenisStudio(kodeTerbaru, textBoxNamaJenisStudio.Text, textBoxDeskripsi.Text);

                //panggil method TambahData di class jenis studio
                JenisStudio.TambahData(js);

                MessageBox.Show("Data jenis studio telah tersimpan.", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaJenisStudio.Text = "";
            textBoxDeskripsi.Text = "";
            textBoxNamaJenisStudio.Focus();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormDaftarJenisStudio formDaftarJenisStudio = (FormDaftarJenisStudio)this.Owner;
            formDaftarJenisStudio.FormDaftarJenisStudio_Load(buttonKembali, e);

            this.Close();
        }
    }
}
