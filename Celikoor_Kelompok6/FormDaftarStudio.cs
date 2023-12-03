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
    public partial class FormDaftarStudio : Form
    {
        public List<Studio> listStudio = new List<Studio>();
        public Studio studioDipilih;

        public FormDaftarStudio()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarStudio.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarStudio.Columns.Add("id", "Id Konsumen");
            dataGridViewDaftarStudio.Columns.Add("nama", "Nama Konsumen");
            dataGridViewDaftarStudio.Columns.Add("kapasitas", "Email");
            dataGridViewDaftarStudio.Columns.Add("jenis_studios_id", "Nomor HP");
            dataGridViewDaftarStudio.Columns.Add("cinemas_id", "Gender");
            dataGridViewDaftarStudio.Columns.Add("harga_weekday", "Tanggal Lahir");
            dataGridViewDaftarStudio.Columns.Add("harga_weekend", "Saldo");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarStudio.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["kapasitas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["jenis_studios_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["cinemas_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["harga_weekday"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarStudio.Columns["harga_weekend"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar gaji rata kanan
            dataGridViewDaftarStudio.Columns["harga_weekday"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarStudio.Columns["harga_weekend"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar gaji ditampilkan dengan format pemisah ribuan (1000 delimiter)
            dataGridViewDaftarStudio.Columns["harga_weekday"].DefaultCellStyle.Format = "#,###";
            dataGridViewDaftarStudio.Columns["harga_weekend"].DefaultCellStyle.Format = "#,###";

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarStudio.AllowUserToAddRows = false;
            dataGridViewDaftarStudio.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarStudio.Rows.Clear();

            if (listStudio.Count > 0) //jika listKonsumen terisi data
            {
                //tampilkan semua isi listPegawai di datagridview
                foreach (Studio s in listStudio)
                {
                    dataGridViewDaftarStudio.Rows.Add(s.Id, s.Nama, s.Kapasitas, s.JenisStudio, s.JenisCinema,
                        s.HargaWeekDay, s.HargaWeekEnd);
                }
            }
            else
            {
                dataGridViewDaftarStudio.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahStudio form = new FormTambahStudio();
            form.Owner = this;
            form.Show();
        }

        private void FormDaftarStudio_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listStudio = Studio.BacaData("", "");

            //tampilkan semua isi listKonsumen di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listStudio.Count > 0) //jika listKategori terisi data
            {
                //cek dulu jika jumlah kolom sudah 8, artinya sudah ada kolom aksi
                if (dataGridViewDaftarStudio.Columns.Count < 8)
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
                    dataGridViewDaftarStudio.Columns.Add(bcol);

                    //menu menghapus objek yang diinginkan
                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Delete";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarStudio.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewDaftarStudio.DataSource = null;
            }
        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxKriteria.Text == "Id")
            {
                kriteria = "S.id";
            }
            else if (comboBoxKriteria.Text == "Nama")
            {
                kriteria = "S.nama";
            }
            else if (comboBoxKriteria.Text == "Kapasitas")
            {
                kriteria = "S.kapasitas";
            }
            else if (comboBoxKriteria.Text == "Jenis Studio")
            {
                kriteria = "S.jenis_studios_id";
            }
            else if (comboBoxKriteria.Text == "Jenis Cinema")
            {
                kriteria = "S.cinemas_id";
            }
            else if (comboBoxKriteria.Text == "Harga WeekDay")
            {
                kriteria = "S.harga_weekday";
            }
            else if (comboBoxKriteria.Text == "Harga WeekEnd")
            {
                kriteria = "S.harga_weekend";
            }

            listStudio = Studio.BacaData(kriteria, textBoxKriteria.Text);

            TampilDataGrid();
        }
    }
}
