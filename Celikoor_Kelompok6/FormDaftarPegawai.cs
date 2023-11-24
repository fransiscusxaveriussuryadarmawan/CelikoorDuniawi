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
    public partial class FormDaftarPegawai : Form
    {
        public List<Pegawai> listPegawai = new List<Pegawai>();
        public Pegawai pegawaiDipilih;

        public FormDaftarPegawai()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarPegawai.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarPegawai.Columns.Add("id", "Id Pegawai");
            dataGridViewDaftarPegawai.Columns.Add("nama", "Nama Pegawai");
            dataGridViewDaftarPegawai.Columns.Add("email", "Email");
            dataGridViewDaftarPegawai.Columns.Add("username", "Username");
            dataGridViewDaftarPegawai.Columns.Add("roles", "Role");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarPegawai.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPegawai.Columns["roles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarPegawai.AllowUserToAddRows = false;
            dataGridViewDaftarPegawai.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarPegawai.Rows.Clear();

            if (listPegawai.Count > 0) //jika listKonsumen terisi data
            {
                //tampilkan semua isi listPegawai di datagridview
                foreach (Pegawai p in listPegawai)
                {
                    dataGridViewDaftarPegawai.Rows.Add(p.Id, p.Nama, p.Email, p.Username, p.Role);
                }
            }
            else
            {
                dataGridViewDaftarPegawai.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai form = new FormTambahPegawai();
            form.Owner = this;
            form.Show();
        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxKriteria.Text == "Id")
            {
                kriteria = "P.id";
            }
            else if (comboBoxKriteria.Text == "Nama")
            {
                kriteria = "P.nama";
            }
            else if (comboBoxKriteria.Text == "Email")
            {
                kriteria = "P.email";
            }
            else if (comboBoxKriteria.Text == "Username")
            {
                kriteria = "P.username";
            }
            else if (comboBoxKriteria.Text == "Role")
            {
                kriteria = "P.roles";
            }

            listPegawai = Pegawai.BacaData(kriteria, textBoxKriteria.Text);

            TampilDataGrid();
        }

        public void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listPegawai = Pegawai.BacaData("", "");

            //tampilkan semua isi listPegawai di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listPegawai.Count > 0) //jika listKategori terisi data
            {
                //cek dulu jika jumlah kolom sudah 6, artinya sudah ada kolom aksi
                if (dataGridViewDaftarPegawai.Columns.Count < 6)
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
                    dataGridViewDaftarPegawai.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewDaftarPegawai.DataSource = null;
            }
        }

        private void dataGridViewDaftarPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarPegawai.CurrentRow.Cells["id"].Value.ToString();
            List<Pegawai> hasil = new List<Pegawai>();
            hasil = Pegawai.BacaData("id", pKode);
            pegawaiDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarPegawai.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.pegawaiDipilih.Id;
                string namaHapus = dataGridViewDaftarPegawai.CurrentRow.Cells["nama"].Value.ToString();
                string emailHapus = dataGridViewDaftarPegawai.CurrentRow.Cells["email"].Value.ToString();
                string usernameHapus = dataGridViewDaftarPegawai.CurrentRow.Cells["username"].Value.ToString();
                string passwordHapus = this.pegawaiDipilih.Password;
                string roleHapus = dataGridViewDaftarPegawai.CurrentRow.Cells["roles"].Value.ToString();

                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    Pegawai p = new Pegawai(kodeHapus, namaHapus, emailHapus, usernameHapus, 
                        passwordHapus, roleHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = Pegawai.HapusData(p);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar pegawai
                        FormDaftarPegawai_Load(buttonKeluar, e);
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
