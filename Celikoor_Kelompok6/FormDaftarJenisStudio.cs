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
    public partial class FormDaftarJenisStudio : Form
    {
        public List<JenisStudio> listJenisStudio = new List<JenisStudio>();
        public JenisStudio jenisStudioDipilih;

        public FormDaftarJenisStudio()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJenisStudio form = new FormTambahJenisStudio();
            form.Owner = this;
            form.Show();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarJenisStudio.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarJenisStudio.Columns.Add("id", "Id Jenis Studio");
            dataGridViewDaftarJenisStudio.Columns.Add("nama", "Nama Jenis Studio");
            dataGridViewDaftarJenisStudio.Columns.Add("deskripsi", "Deskripsi");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarJenisStudio.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarJenisStudio.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarJenisStudio.Columns["deskripsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarJenisStudio.AllowUserToAddRows = false;
            dataGridViewDaftarJenisStudio.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarJenisStudio.Rows.Clear();

            if (listJenisStudio.Count > 0) //jika listKonsumen terisi data
            {
                //tampilkan semua isi listPegawai di datagridview
                foreach (JenisStudio j in listJenisStudio)
                {
                    dataGridViewDaftarJenisStudio.Rows.Add(j.Id, j.Nama, j.Deskripsi);
                }
            }
            else
            {
                dataGridViewDaftarJenisStudio.DataSource = null;
            }
        }

        public void FormDaftarJenisStudio_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listJenisStudio = JenisStudio.BacaData("", "");

            //tampilkan semua isi listJenisStudio di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listJenisStudio.Count > 0) //jika listJenisStudio terisi data
            {
                //cek dulu jika jumlah kolom sudah 4, artinya sudah ada kolom aksi
                if (dataGridViewDaftarJenisStudio.Columns.Count < 4)
                {
                    //Inisiasi object dengan tipe DataGridViewButtonColumn untuk membuat tombol pada kolom datagrid
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();

                    //Tentukan judul header dari kolom tombol
                    bcol.HeaderText = "Delete";

                    //Tentukan text dari tombol yang dibuat
                    bcol.Text = "Hapus";

                    //Tentukan nama dari tombol yang dibuat
                    bcol.Name = "buttonHapusGrid";

                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarJenisStudio.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewDaftarJenisStudio.DataSource = null;
            }
        }

        private void dataGridViewDaftarJenisStudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarJenisStudio.CurrentRow.Cells["id"].Value.ToString();
            List<JenisStudio> hasil = new List<JenisStudio>();
            hasil = JenisStudio.BacaData("id", pKode);
            jenisStudioDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarJenisStudio.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.jenisStudioDipilih.Id;
                string namaHapus = dataGridViewDaftarJenisStudio.CurrentRow.Cells["nama"].Value.ToString();
                string deskripsiHapus = dataGridViewDaftarJenisStudio.CurrentRow.Cells["deskripsi"].Value.ToString();

                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    JenisStudio j = new JenisStudio(kodeHapus, namaHapus, deskripsiHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = JenisStudio.HapusData(j);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar jenis studio
                        FormDaftarJenisStudio_Load(buttonKeluar, e);
                    }

                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
        }
    }
}
