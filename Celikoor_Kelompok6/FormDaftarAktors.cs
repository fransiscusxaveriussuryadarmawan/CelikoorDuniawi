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
    public partial class FormDaftarAktors : Form
    {
        public List<Aktor> listAktor = new List<Aktor>();
        public Aktor aktorDipilih;

        public FormDaftarAktors()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahAktors form = new FormTambahAktors();
            form.Owner = this;
            form.Show();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDaftarAktor.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarAktor.Columns.Add("id", "Id Aktors");
            dataGridViewDaftarAktor.Columns.Add("nama", "Nama Aktors");
            dataGridViewDaftarAktor.Columns.Add("tgl_lahir", "Tanggal Lahir");
            dataGridViewDaftarAktor.Columns.Add("gender", "Gender");
            dataGridViewDaftarAktor.Columns.Add("negara_asal", "Negara Asal");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarAktor.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarAktor.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarAktor.Columns["tgl_lahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarAktor.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarAktor.Columns["negara_asal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarAktor.AllowUserToAddRows = false;
            dataGridViewDaftarAktor.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarAktor.Rows.Clear();

            if (listAktor.Count > 0) //jika listAktor terisi data
            {
                //tampilkan semua isi listAktor di datagridview
                foreach (Aktor a in listAktor)
                {
                    dataGridViewDaftarAktor.Rows.Add(a.Id, a.Nama, a.TanggalLahir , a.Gender, a.NegaraAsal);
                }
            }
            else
            {
                dataGridViewDaftarAktor.DataSource = null;
            }
        }

        public void FormDaftarAktors_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listAktor = Aktor.BacaData("", "");

            //tampilkan semua isi listKonsumen di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listAktor.Count > 0) //jika listKategori terisi data
            {
                //cek dulu jika jumlah kolom sudah 6, artinya sudah ada kolom aksi
                if (dataGridViewDaftarAktor.Columns.Count < 6)
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
                    dataGridViewDaftarAktor.Columns.Add(bcol);

                    //menu menghapus objek yang diinginkan
                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Delete";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarAktor.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewDaftarAktor.DataSource = null;
            }
        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxKriteria.Text == "Id")
            {
                kriteria = "A.id";
            }
            else if (comboBoxKriteria.Text == "Nama")
            {
                kriteria = "A.nama";
            }
            else if (comboBoxKriteria.Text == "Tanggal Lahir")
            {
                kriteria = "A.email";
            }
            else if (comboBoxKriteria.Text == "Gender")
            {
                kriteria = "A.no_hp";
            }
            else if (comboBoxKriteria.Text == "Negara Asal")
            {
                kriteria = "A.gender";
            }

            listAktor = Aktor.BacaData(kriteria, textBoxKriteria.Text);

            TampilDataGrid();
        }

        private void dataGridViewDaftarAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarAktor.CurrentRow.Cells["id"].Value.ToString();
            List<Aktor> hasil = new List<Aktor>();
            hasil = Aktor.BacaData("id", pKode);
            aktorDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON UBAH
            if (e.ColumnIndex == dataGridViewDaftarAktor.Columns["buttonUbahGrid"].Index && e.RowIndex >= 0)
            {
                if (hasil.Count == 1)
                {
                    FormUbahAktors form = new FormUbahAktors();
                    form.Owner = this;

                    string gender = dataGridViewDaftarAktor.CurrentRow.Cells["gender"].Value.ToString();

                    form.textBoxNama.Text = dataGridViewDaftarAktor.CurrentRow.Cells["nama"].Value.ToString();
                    
                    if (gender == "L")
                    {
                        form.radioButtonLaki.Checked = true;
                    }
                    else if (gender == "P")
                    {
                        form.radioButtonWanita.Checked = true;
                    }

                    form.dateTimePickerTanggalLahir.Value = DateTime.Parse(dataGridViewDaftarAktor.CurrentRow.Cells["tgl_lahir"].Value.ToString());
                    form.textBoxNegaraAsal.Text = dataGridViewDaftarAktor.CurrentRow.Cells["negara_asal"].Value.ToString();

                    form.aktorDipilih = this.aktorDipilih;
                    form.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }


            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarAktor.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.aktorDipilih.Id;
                string namaHapus = dataGridViewDaftarAktor.CurrentRow.Cells["nama"].Value.ToString();
                DateTime tgllahirHapus = this.aktorDipilih.TanggalLahir;
                string genderHapus = dataGridViewDaftarAktor.CurrentRow.Cells["gender"].Value.ToString();
                string negaraHapus = dataGridViewDaftarAktor.CurrentRow.Cells["negara_asal"].Value.ToString();

                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    Aktor a = new Aktor(kodeHapus, namaHapus, tgllahirHapus, genderHapus, negaraHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = Aktor.HapusData(a);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar konsumen
                        FormDaftarAktors_Load(buttonKeluar, e);
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
