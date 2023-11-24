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
    public partial class FormDaftarGenre : Form
    {
        public List<Genre> listGenre = new List<Genre>();
        public Genre genreDipilih;

        public FormDaftarGenre()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahGenre form = new FormTambahGenre();
            form.Owner = this;
            form.Show();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarGenre.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarGenre.Columns.Add("id", "Id Genre");
            dataGridViewDaftarGenre.Columns.Add("nama", "Nama Genre");
            dataGridViewDaftarGenre.Columns.Add("deskripsi", "Deskripsi Genre");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarGenre.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarGenre.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarGenre.Columns["deskripsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarGenre.AllowUserToAddRows = false;
            dataGridViewDaftarGenre.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarGenre.Rows.Clear();

            if (listGenre.Count > 0) //jika listGenre terisi data
            {
                //tampilkan semua isi listGenre di datagridview
                foreach (Genre g in listGenre)
                {
                    dataGridViewDaftarGenre.Rows.Add(g.Id, g.Nama, g.Deskripsi);
                }
            }
            else
            {
                dataGridViewDaftarGenre.DataSource = null;
            }
        }

        public void FormDaftarGenre_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listGenre = Genre.BacaData("", "");

            //tampilkan semua isi listGenre di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listGenre.Count > 0) //jika listGenre terisi data
            {
                //cek dulu jika jumlah kolom sudah 4, artinya sudah ada kolom aksi
                if (dataGridViewDaftarGenre.Columns.Count < 4)
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
                    dataGridViewDaftarGenre.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewDaftarGenre.DataSource = null;
            }
        }

        private void dataGridViewDaftarGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarGenre.CurrentRow.Cells["id"].Value.ToString();
            List<Genre> hasil = new List<Genre>();
            hasil = Genre.BacaData("id", pKode);
            genreDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarGenre.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.genreDipilih.Id;
                string namaHapus = dataGridViewDaftarGenre.CurrentRow.Cells["nama"].Value.ToString();
                string deskripsiHapus = dataGridViewDaftarGenre.CurrentRow.Cells["deskripsi"].Value.ToString();
                
                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    Genre g = new Genre(kodeHapus, namaHapus, deskripsiHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = Genre.HapusData(g);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar cinema
                        FormDaftarGenre_Load(buttonKeluar, e);
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
