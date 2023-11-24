using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Kelompok
    {
        private string id;
        private string nama;

        #region constructors
        public Kelompok(string id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }

        public Kelompok()
        {
            this.Id = "";
            this.Nama = "";
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region methods
        //Method Tambah Data
        public static void TambahData(Kelompok k)
        {
            string sql = "INSERT INTO kelompoks (id, nama) " +
                        " values ('" + k.Id + "','" + k.Nama + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode kelompok terakhir (kode terbesar)
            string sql = "select max(id) from kelompoks";

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

        //Method Baca Data
        public static List<Kelompok> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select K.id, K.nama" +
                    " from kelompoks K";
            }

            else
            {
                sql = "select K.id, K.nama" +
                    " from kelompoks K" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Kelompok> listKelompok = new List<Kelompok>(); //listnya berisi objek kelompok
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                Kelompok k = new Kelompok();
                k.Id = hasil.GetValue(0).ToString();
                k.Nama = hasil.GetValue(1).ToString();

                listKelompok.Add(k);
            }
            return listKelompok;
        }

        //Method Hapus Data
        public static Boolean HapusData(Kelompok pK)
        {
            string perintah = "delete from kelompoks where id='" + pK.Id + "'";

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
