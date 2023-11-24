using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Genre
    {
        private string id;
        private string nama;
        private string deskripsi;

        #region constructors
        public Genre(string id, string nama, string deskripsi)
        {
            this.Id = id;
            this.Nama = nama;
            this.Deskripsi = deskripsi;
        }

        public Genre()
        {
            this.Id = "";
            this.Nama = "";
            this.Deskripsi = "";
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region methods
        //Method Tambah Data
        public static void TambahData(Genre g)
        {
            string sql = "INSERT INTO genres (id, nama, deskripsi) " +
                        " values ('" + g.Id + "','" + g.Nama + "','" + g.Deskripsi + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Baca Data
        public static List<Genre> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select g.id, g.nama, g.deskripsi " +
                    " from genres g";
            }

            else
            {
                sql = "select g.id, g.nama, g.deskripsi " +
                    " from genres g" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Genre> listGenre = new List<Genre>(); //listnya berisi objek genre
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                Genre g = new Genre();
                g.Id = hasil.GetValue(0).ToString();
                g.Nama = hasil.GetValue(1).ToString();
                g.Deskripsi = hasil.GetValue(2).ToString();


                listGenre.Add(g);
            }
            return listGenre;
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode genre terakhir (kode terbesar)
            string sql = "select max(id) from genres";

            string hasilKode = "";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() != true)
            {
                hasilKode = "1";
            }
            else
            {
                int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;

                hasilKode = kodeTerbaru.ToString();
            }

            return hasilKode;
        }

        //Method Hapus Data
        public static Boolean HapusData(Genre pG)
        {
            string perintah = "delete from genres where id='" + pG.Id + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahNonQuery(perintah);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
