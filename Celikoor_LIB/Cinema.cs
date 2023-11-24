using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Cinema
    {
        private string id;
        private string namaCabang;
        private string alamat;
        private DateTime tglDibuka;
        private string kota;

        #region constructors
        public Cinema(string id, string namaCabang, string alamat, DateTime tglDibuka, string kota)
        {
            this.Id = id;
            this.NamaCabang = namaCabang;
            this.Alamat = alamat;
            this.TglDibuka = tglDibuka;
            this.Kota = kota;
        }

        public Cinema()
        {
            this.Id = "";
            this.NamaCabang = "";
            this.Alamat = "";
            this.TglDibuka = DateTime.Now;
            this.Kota = "";
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string NamaCabang { get => namaCabang; set => namaCabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime TglDibuka { get => tglDibuka; set => tglDibuka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region methods
        //Method Tambah Data
        public static void TambahData(Cinema c)
        {
            string sql = "INSERT INTO cinemas (id, nama_cabang, alamat, tgl_dibuka, kota) " +
                        " values ('" + c.Id + "','" + c.NamaCabang + "','" + c.Alamat + "','" + c.TglDibuka.ToString("yyyy-MM-dd") + "','" +
                        c.Kota + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Baca Data
        public static List<Cinema> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select C.id, C.nama_cabang, C.alamat, C.tgl_dibuka, C.kota " +
                    " from cinemas C";
            }

            else
            {
                sql = "select C.id, C.nama_cabang, C.alamat, C.tgl_dibuka, C.kota " +
                    " from cinemas C" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Cinema> listCinema = new List<Cinema>(); //listnya berisi objek cinema
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                Cinema c = new Cinema();
                c.Id = hasil.GetValue(0).ToString();
                c.NamaCabang = hasil.GetValue(1).ToString();
                c.Alamat = hasil.GetValue(2).ToString();
                c.TglDibuka = DateTime.Parse(hasil.GetValue(3).ToString());
                c.Kota = hasil.GetValue(4).ToString();

                listCinema.Add(c);
            }
            return listCinema;
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode cinema terakhir (kode terbesar)
            string sql = "select max(id) from cinemas";

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
        public static Boolean HapusData(Cinema pC)
        {
            string perintah = "delete from cinemas where id='" + pC.Id + "'";

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
