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
    public partial class FormDaftarCinema : Form
    {
        public List<Cinema> listCinema = new List<Cinema>();
        public Cinema cinemaDipilih;

        public FormDaftarCinema()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCinema form = new FormTambahCinema();
            form.Owner = this;
            form.Show();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarCinema.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarCinema.Columns.Add("id", "Id Cinema");
            dataGridViewDaftarCinema.Columns.Add("nama_cabang", "Nama Cinema");
            dataGridViewDaftarCinema.Columns.Add("alamat", "Alamat");
            dataGridViewDaftarCinema.Columns.Add("tgl_dibuka", "Tanggal Dibuka");
            dataGridViewDaftarCinema.Columns.Add("kota", "Kota");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarCinema.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinema.Columns["nama_cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinema.Columns["alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinema.Columns["tgl_dibuka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCinema.Columns["kota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarCinema.AllowUserToAddRows = false;
            dataGridViewDaftarCinema.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarCinema.Rows.Clear();

            if (listCinema.Count > 0) //jika listKonsumen terisi data
            {
                //tampilkan semua isi listPegawai di datagridview
                foreach (Cinema c in listCinema)
                {
                    dataGridViewDaftarCinema.Rows.Add(c.Id, c.NamaCabang, c.Alamat, c.TglDibuka, c.Kota);
                }
            }
            else
            {
                dataGridViewDaftarCinema.DataSource = null;
            }
        }

        public void FormDaftarCinema_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listCinema = Cinema.BacaData("", "");

            //tampilkan semua isi listCinema di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listCinema.Count > 0) //jika listKategori terisi data
            {
                //cek dulu jika jumlah kolom sudah 6, artinya sudah ada kolom aksi
                if (dataGridViewDaftarCinema.Columns.Count < 6)
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
                    dataGridViewDaftarCinema.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewDaftarCinema.DataSource = null;
            }
        }

        private void dataGridViewDaftarCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarCinema.CurrentRow.Cells["id"].Value.ToString();
            List<Cinema> hasil = new List<Cinema>();
            hasil = Cinema.BacaData("id", pKode);
            cinemaDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarCinema.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.cinemaDipilih.Id;
                string namaHapus = dataGridViewDaftarCinema.CurrentRow.Cells["nama_cabang"].Value.ToString();
                string alamatHapus = dataGridViewDaftarCinema.CurrentRow.Cells["alamat"].Value.ToString();
                DateTime tglDibukaHapus = this.cinemaDipilih.TglDibuka;
                string kotaHapus = dataGridViewDaftarCinema.CurrentRow.Cells["kota"].Value.ToString();

                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    Cinema c = new Cinema(kodeHapus, namaHapus, alamatHapus, tglDibukaHapus, kotaHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = Cinema.HapusData(c);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar cinema
                        FormDaftarCinema_Load(buttonKeluar, e);
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
