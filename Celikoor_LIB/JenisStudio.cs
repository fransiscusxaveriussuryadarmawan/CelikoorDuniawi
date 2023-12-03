using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class JenisStudio
    {
        private string id;
        private string nama;
        private string deskripsi;

        #region constructors
        public JenisStudio(string id, string nama, string deskripsi)
        {
            this.Id = id;
            this.Nama = nama;
            this.Deskripsi = deskripsi;
        }

        public JenisStudio()
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
        //Method Baca Data
        public static List<JenisStudio> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select J.id, J.nama, J.deskripsi " +
                    " from jenis_studios J";
            }

            else
            {
                sql = "select J.id, J.nama, J.deskripsi " +
                    " from jenis_studios J" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<JenisStudio> listJenisStudio = new List<JenisStudio>(); //listnya berisi objek jenis studio
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                JenisStudio j = new JenisStudio();
                j.Id = hasil.GetValue(0).ToString();
                j.Nama = hasil.GetValue(1).ToString();
                j.Deskripsi = hasil.GetValue(2).ToString();

                listJenisStudio.Add(j);
            }
            return listJenisStudio;
        }

        //Method Hapus Data
        public static Boolean HapusData(JenisStudio jC)
        {
            string perintah = "delete from jenis_studios where id='" + jC.Id + "'";

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

        //method untuk kode id
        public static string GenerateKode()
        {
            //dapatkan kode kelompok terakhir (kode terbesar)
            string sql = "select max(id) from jenis_studios";

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

        //method untuk tambah data
        public static void TambahData(JenisStudio js)
        {
            string sql = "INSERT INTO jenis_studios (id, nama, deskripsi) " +
                        " values ('" + js.Id + "','" + js.Nama + "', '" + js.Deskripsi + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
        #endregion
    }
}
