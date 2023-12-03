using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class JadwalFilm
    {
        private string id;
        private DateTime tglDate;
        private string jamPemutaran;

        #region constructors
        public JadwalFilm(string id, DateTime tglDate, string jamPemutaran)
        {
            this.Id = id;
            this.TglDate = tglDate;
            this.JamPemutaran = jamPemutaran;
        }

        public JadwalFilm()
        {
            this.Id = "";
            this.TglDate = DateTime.Now;
            this.JamPemutaran = "";
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public DateTime TglDate { get => tglDate; set => tglDate = value; }
        public string JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }
        #endregion

        #region methods
        //Method Tambah Data
        public static void TambahData(JadwalFilm j)
        {
            string sql = "INSERT INTO jadwal_films (id, tanggal, jam_pemutaran) " +
                        " values ('" + j.Id + "','" + j.TglDate.ToString("yyyy-MM-dd") + "','" + j.JamPemutaran + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode konsumen terakhir (kode terbesar)
            string sql = "select max(id) from jadwal_films";

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
        public static List<JadwalFilm> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select J.id, J.tanggal, J.jam_pemutaran " +
                    " from jadwal_films J";
            }
            else
            {
                sql = "select J.id, J.tanggal, J.jam_pemutaran " +
                    " from jadwal_films J" + 
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>(); //listnya berisi objek konsumen
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                JadwalFilm jf = new JadwalFilm();
                jf.Id = hasil.GetValue(0).ToString();
                jf.TglDate = DateTime.Parse(hasil.GetValue(1).ToString());
                jf.JamPemutaran = hasil.GetValue(2).ToString();

                listJadwalFilm.Add(jf);
            }
            return listJadwalFilm;
        }

        //Method Ubah Data
        public static void UbahData(JadwalFilm jf)
        {
            string sql = "update jadwal_films set tanggal='" + jf.TglDate.ToString("yyyy-MM-dd") +
                            "',jam_pemutaran='" + jf.JamPemutaran +
                            "' where id='" + jf.Id +
                            "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Hapus Data
        public static Boolean HapusData(JadwalFilm pJf)
        {
            string sql = "delete from jadwal_films where id='" + pJf.Id + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahNonQuery(sql);
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
