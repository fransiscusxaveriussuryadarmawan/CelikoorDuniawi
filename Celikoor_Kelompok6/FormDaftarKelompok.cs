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
    public partial class FormDaftarKelompok : Form
    {
        public List<Kelompok> listKelompok = new List<Kelompok>();
        public Kelompok kelompokDipilih;

        public FormDaftarKelompok()
        {
            InitializeComponent();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarKelompok.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarKelompok.Columns.Add("id", "Id Kelompok");
            dataGridViewDaftarKelompok.Columns.Add("nama", "Nama Kelompok");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarKelompok.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKelompok.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarKelompok.AllowUserToAddRows = false;
            dataGridViewDaftarKelompok.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarKelompok.Rows.Clear();

            if (listKelompok.Count > 0) //jika listKonsumen terisi data
            {
                //tampilkan semua isi listPegawai di datagridview
                foreach (Kelompok k in listKelompok)
                {
                    dataGridViewDaftarKelompok.Rows.Add(k.Id, k.Nama);
                }
            }
            else
            {
                dataGridViewDaftarKelompok.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKelompok form = new FormTambahKelompok();
            form.Owner = this;
            form.Show();
        }

        public void FormDaftarKelompok_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listKelompok = Kelompok.BacaData("", "");

            //tampilkan semua isi listCinema di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listKelompok.Count > 0) //jika listKategori terisi data
            {
                //cek dulu jika jumlah kolom sudah 3, artinya sudah ada kolom aksi
                if (dataGridViewDaftarKelompok.Columns.Count < 3)
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
                    dataGridViewDaftarKelompok.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewDaftarKelompok.DataSource = null;
            }
        }

        private void dataGridViewDaftarKelompok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarKelompok.CurrentRow.Cells["id"].Value.ToString();
            List<Kelompok> hasil = new List<Kelompok>();
            hasil = Kelompok.BacaData("id", pKode);
            kelompokDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarKelompok.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.kelompokDipilih.Id;
                string namaHapus = dataGridViewDaftarKelompok.CurrentRow.Cells["nama"].Value.ToString();

                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    Kelompok k = new Kelompok(kodeHapus, namaHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = Kelompok.HapusData(k);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar Kelompok
                        FormDaftarKelompok_Load(buttonKeluar, e);
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
