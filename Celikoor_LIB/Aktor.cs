using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor
    {
        private string id;
        private string nama;
        private DateTime tanggalLahir;
        private string gender;
        private string negaraAsal;

        #region constructors
        public Aktor(string id, string nama, DateTime tanggalLahir, string gender, string negaraAsal)
        {
            this.Id = id;
            this.Nama = nama;
            this.TanggalLahir = tanggalLahir;
            this.Gender = gender;
            this.NegaraAsal = negaraAsal;
        }

        public Aktor()
        {
            this.id = "";
            this.nama = "";
            this.tanggalLahir = DateTime.Now;
            this.gender = "";
            this.negaraAsal = "";
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TanggalLahir { get => tanggalLahir; set => tanggalLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }
        #endregion

        #region methods
        //Method Baca Data
        public static List<Aktor> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select A.id, A.nama, A.tgl_lahir, A.gender, A.negara_asal " +
                    " from aktors A";
            }
            else
            {
                sql = "select A.id, A.nama, A.tgl_lahir, A.gender, A.negara_asal " +
                    " from aktors A" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Aktor> listAktor = new List<Aktor>(); //listnya berisi objek Aktor
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                Aktor a = new Aktor();
                a.Id = hasil.GetValue(0).ToString();
                a.Nama = hasil.GetValue(1).ToString();
                a.TanggalLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                a.Gender = hasil.GetValue(3).ToString();
                a.NegaraAsal = hasil.GetValue(4).ToString();

                listAktor.Add(a);
            }
            return listAktor;
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode genre terakhir (kode terbesar)
            string sql = "select max(id) from aktors";

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

        //Method Ubah Data
        public static void UbahData(Aktor a)
        {
            string sql = "update aktors set nama='" + a.Nama +
                            "',tgl_lahir='" + a.TanggalLahir.ToString("yyyy-MM-dd") +
                            "',gender='" + a.Gender +
                            "',negara_asal='" + a.NegaraAsal +
                            "' where id='" + a.Id +
                            "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Tambah Data
        public static void TambahData(Aktor a)
        {
            string sql = "INSERT INTO aktors (id, nama, tgl_lahir, gender, negara_asal)" +
            "VALUES ('" + a.Id + "', '" + a.Nama + "', '" + a.TanggalLahir.ToString("yyyy-MM-dd") + "', '" + a.Gender + "', '" + a.NegaraAsal + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Hapus Data
        public static Boolean HapusData(Aktor pA)
        {
            string perintah = "delete from aktors where id='" + pA.Id + "'";

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
