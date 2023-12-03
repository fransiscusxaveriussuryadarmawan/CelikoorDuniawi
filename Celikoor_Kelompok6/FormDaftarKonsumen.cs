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
    public partial class FormDaftarKonsumen : Form
    {
        public List<Konsumen> listKonsumen = new List<Konsumen>();
        public Konsumen konsumenDipilih;

        public FormDaftarKonsumen()
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
            dataGridViewDaftarKonsumen.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDaftarKonsumen.Columns.Add("id", "Id Konsumen");
            dataGridViewDaftarKonsumen.Columns.Add("nama", "Nama Konsumen");
            dataGridViewDaftarKonsumen.Columns.Add("email", "Email");
            dataGridViewDaftarKonsumen.Columns.Add("no_hp", "Nomor HP");
            dataGridViewDaftarKonsumen.Columns.Add("gender", "Gender");
            dataGridViewDaftarKonsumen.Columns.Add("tgl_lahir", "Tanggal Lahir");
            dataGridViewDaftarKonsumen.Columns.Add("saldo", "Saldo");
            dataGridViewDaftarKonsumen.Columns.Add("username", "Username");

            //agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewDaftarKonsumen.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["no_hp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["tgl_lahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["saldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKonsumen.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar gaji rata kanan
            dataGridViewDaftarKonsumen.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar gaji ditampilkan dengan format pemisah ribuan (1000 delimiter)
            dataGridViewDaftarKonsumen.Columns["saldo"].DefaultCellStyle.Format = "#,###";

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDaftarKonsumen.AllowUserToAddRows = false;
            dataGridViewDaftarKonsumen.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            //kosongi isi data gridview
            dataGridViewDaftarKonsumen.Rows.Clear();

            if (listKonsumen.Count > 0) //jika listKonsumen terisi data
            {
                //tampilkan semua isi listPegawai di datagridview
                foreach (Konsumen k in listKonsumen)
                {
                    dataGridViewDaftarKonsumen.Rows.Add(k.Id, k.Nama, k.Email, k.NoHP, k.Gender,
                        k.TglLahir, k.Saldo, k.Username);
                }
            }
            else
            {
                dataGridViewDaftarKonsumen.DataSource = null;
            }
        }

        public void FormDaftarKonsumen_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            listKonsumen = Konsumen.BacaData("", "");

            //tampilkan semua isi listKonsumen di datagridview (Panggil method tampildatagrid)
            TampilDataGrid();

            if (listKonsumen.Count > 0) //jika listKategori terisi data
            {
                //cek dulu jika jumlah kolom sudah 9, artinya sudah ada kolom aksi
                if (dataGridViewDaftarKonsumen.Columns.Count < 9)
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
                    dataGridViewDaftarKonsumen.Columns.Add(bcol);

                    //menu menghapus objek yang diinginkan
                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Delete";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarKonsumen.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewDaftarKonsumen.DataSource = null;
            }
        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxKriteria.Text == "Id")
            {
                kriteria = "K.id";
            }
            else if (comboBoxKriteria.Text == "Nama")
            {
                kriteria = "K.nama";
            }
            else if (comboBoxKriteria.Text == "Email")
            {
                kriteria = "K.email";
            }
            else if (comboBoxKriteria.Text == "Nomor HP")
            {
                kriteria = "K.no_hp";
            }
            else if (comboBoxKriteria.Text == "Gender")
            {
                kriteria = "K.gender";
            }
            else if (comboBoxKriteria.Text == "Tanggal Lahir")
            {
                kriteria = "K.tgl_lahir";
            }
            else if (comboBoxKriteria.Text == "Saldo")
            {
                kriteria = "K.saldo";
            }
            else if (comboBoxKriteria.Text == "Username")
            {
                kriteria = "K.username";
            }

            listKonsumen = Konsumen.BacaData(kriteria, textBoxKriteria.Text);

            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKonsumen form = new FormTambahKonsumen();
            form.Owner = this;
            form.Show();
        }

        private void dataGridViewDaftarKonsumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKode = dataGridViewDaftarKonsumen.CurrentRow.Cells["id"].Value.ToString();
            List<Konsumen> hasil = new List<Konsumen>();
            hasil = Konsumen.BacaData("id", pKode);
            konsumenDipilih = hasil[0]; //langsung index 0 karena cuman terisi 1 data

            //JIKA KLIK BUTTON UBAH
            if (e.ColumnIndex == dataGridViewDaftarKonsumen.Columns["buttonUbahGrid"].Index && e.RowIndex >= 0)
            {
                if (hasil.Count == 1)
                {
                    FormUbahKonsumen form = new FormUbahKonsumen();
                    form.Owner = this;

                    string gender = dataGridViewDaftarKonsumen.CurrentRow.Cells["gender"].Value.ToString();

                    form.textBoxNama.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["nama"].Value.ToString();
                    form.textBoxEmail.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["email"].Value.ToString();
                    form.textBoxNomorHP.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["no_hp"].Value.ToString();

                    if (gender == "L")
                    {
                        form.radioButtonLaki.Checked = true;
                    }
                    else if (gender == "P")
                    {
                        form.radioButtonWanita.Checked = true;
                    }

                    form.dateTimePickerTanggalLahir.Value = DateTime.Parse(dataGridViewDaftarKonsumen.CurrentRow.Cells["tgl_lahir"].Value.ToString());
                    form.textBoxSaldo.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["saldo"].Value.ToString();
                    form.textBoxUsername.Text = dataGridViewDaftarKonsumen.CurrentRow.Cells["username"].Value.ToString();
                    form.textBoxPassword.Text = konsumenDipilih.Password;
                    form.textBoxUlangPassword.Text = konsumenDipilih.Password;

                    form.konsumenDipilih = this.konsumenDipilih;
                    form.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }


            //JIKA KLIK BUTTON HAPUS
            if (e.ColumnIndex == dataGridViewDaftarKonsumen.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = this.konsumenDipilih.Id;
                string namaHapus = dataGridViewDaftarKonsumen.CurrentRow.Cells["nama"].Value.ToString();
                string emailHapus = dataGridViewDaftarKonsumen.CurrentRow.Cells["email"].Value.ToString();
                string nohpHapus = dataGridViewDaftarKonsumen.CurrentRow.Cells["no_hp"].Value.ToString();
                string genderHapus = dataGridViewDaftarKonsumen.CurrentRow.Cells["gender"].Value.ToString();
                DateTime tgllahirHapus = this.konsumenDipilih.TglLahir;
                double saldoHapus = this.konsumenDipilih.Saldo;
                string usernameHapus = dataGridViewDaftarKonsumen.CurrentRow.Cells["username"].Value.ToString();
                string passwordHapus = this.konsumenDipilih.Password;

                // TAMPILKAN KONFIRMASI
                DialogResult hasilJawaban = MessageBox.Show(this, "Anda yakin akan menghapus " + kodeHapus + "-" +
                    namaHapus + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //JIKA USER MEMILIH TOMBOL YES
                if (hasilJawaban == DialogResult.Yes)
                {
                    //BENTUK OBJEK YANG AKAN DIHAPUS
                    Konsumen k = new Konsumen(kodeHapus, namaHapus, emailHapus, nohpHapus, genderHapus,
                        tgllahirHapus, saldoHapus, usernameHapus, passwordHapus);

                    //PANGGIL METHOD HAPUS DATA
                    Boolean hapus = Konsumen.HapusData(k);

                    //TAMPILKAN PESAN BERHASIL / TIDAK
                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        //refresh form daftar konsumen
                        FormDaftarKonsumen_Load(buttonKeluar, e);
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

        private void comboBoxKriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCariBerdasarkan_Click(object sender, EventArgs e)
        {

        }

        private void labelDaftarKonsumen_Click(object sender, EventArgs e)
        {

        }

        private void panelDaftarKonsumen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
