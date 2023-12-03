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
    public partial class FormDaftarJadwalFilms : Form
    {
        public List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();
        public JadwalFilm jadwalFilmDipilih;

        public FormDaftarJadwalFilms()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJadwalFilms form = new FormTambahJadwalFilms();
            form.Owner = this;
            form.Show();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarJadwalFilm.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarJadwalFilm.Columns.Add("id", "Id Jadwal Film");
            dataGridViewDaftarJadwalFilm.Columns.Add("tanggal", "Tanggal Film");
            dataGridViewDaftarJadwalFilm.Columns.Add("jam_pemutaran", "Jam Pemutaran");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarJadwalFilm.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarJadwalFilm.Columns["tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarJadwalFilm.Columns["jam_pemutaran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarJadwalFilm.AllowUserToAddRows = false;
            dataGridViewDaftarJadwalFilm.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarJadwalFilm.Rows.Clear();

            if (listJadwalFilm.Count > 0) //jika listKonsumen terisi data
            {
                //tampilkan semua isi listPegawai di datagridview
                foreach (JadwalFilm j in listJadwalFilm)
                {
                    dataGridViewDaftarJadwalFilm.Rows.Add(j.Id, j.TglDate, j.JamPemutaran);
                }
            }
            else
            {
                dataGridViewDaftarJadwalFilm.DataSource = null;
            }
        }

        public void FormDaftarJadwalFilms_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listJadwalFilm = JadwalFilm.BacaData("", "");

            //tampilkan semua isi listKonsumen di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listJadwalFilm.Count > 0) //jika listKategori terisi data
            {
                //cek dulu jika jumlah kolom sudah 4, artinya sudah ada kolom aksi
                if (dataGridViewDaftarJadwalFilm.Columns.Count < 4)
                {
                    //Inisiasi object dengan tipe DataGridViewButtonColumn untuk membuat tombol pada kolom datagrid
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();

                    //Tentukan judul header dari kolom tombol
                    bcol.HeaderText = "Update";

                    //Tentukan text dari tombol yang dibuat
                    bcol.Text = "Ubah";

                    //Tentukan nama dari tombol yang dibuat
                    bcol.Name = "buttonUbahGrid";

                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarJadwalFilm.Columns.Add(bcol);

                    //menu menghapus objek yang diinginkan
                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Delete";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarJadwalFilm.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewDaftarJadwalFilm.DataSource = null;
            }
        }

        private void dataGridViewDaftarJadwalFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarJadwalFilm.CurrentRow.Cells["id"].Value.ToString();
            List<JadwalFilm> hasil = new List<JadwalFilm>();
            hasil = JadwalFilm.BacaData("id", pKode);
            jadwalFilmDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON UBAH
            if (e.ColumnIndex == dataGridViewDaftarJadwalFilm.Columns["buttonUbahGrid"].Index && e.RowIndex >= 0)
            {
                if (hasil.Count == 1)
                {
                    FormUbahJadwalFilms form = new FormUbahJadwalFilms();
                    form.Owner = this;

                    form.dateTimePickerTanggalLahir.Value = jadwalFilmDipilih.TglDate;
                    form.comboBoxJamPemutaran.Text = jadwalFilmDipilih.JamPemutaran;

                    //form.textBoxNama.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["nama"].Value.ToString();
                    //form.textBoxEmail.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["email"].Value.ToString();
                    //form.textBoxNomorHP.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["no_hp"].Value.ToString();

                    form.jadwalFilmDipilih = this.jadwalFilmDipilih;
                    form.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }


            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarJadwalFilm.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.jadwalFilmDipilih.Id;
                DateTime tanggalHapus = this.jadwalFilmDipilih.TglDate;
                string jamHapus = dataGridViewDaftarJadwalFilm.CurrentRow.Cells["jam_pemutaran"].Value.ToString();

                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    tanggalHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    JadwalFilm j = new JadwalFilm(kodeHapus, tanggalHapus, jamHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = JadwalFilm.HapusData(j);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar konsumen
                        FormDaftarJadwalFilms_Load(buttonKeluar, e);
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

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxKriteria.Text == "Id")
            {
                kriteria = "J.id";
            }
            else if (comboBoxKriteria.Text == "Tanggal")
            {
                kriteria = "J.tanggal";
            }
            else if (comboBoxKriteria.Text == "Jam Pemutaran")
            {
                kriteria = "J.jam_pemutaran";
            }
            

            listJadwalFilm = JadwalFilm.BacaData(kriteria, textBoxKriteria.Text);

            TampilDataGrid();
        }
    }
}
