using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Konsumen
    {
        private string id;
        private string nama;
        private string email;
        private string noHP;
        private string gender;
        private DateTime tglLahir;
        private double saldo;
        private string username;
        private string password;

        #region constructors
        public Konsumen(string id, string nama, string email, string noHP, string gender, DateTime tglLahir, double saldo, string username, string password)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.NoHP = noHP;
            this.Gender = gender;
            this.TglLahir = tglLahir;
            this.Saldo = saldo;
            this.Username = username;
            this.Password = password;
        }

        public Konsumen()
        {
            this.Id = "";
            this.Nama = "";
            this.Email = "";
            this.NoHP = "";
            this.Gender = "";
            this.TglLahir = DateTime.Now;
            this.Saldo = 0;
            this.Username = "";
            this.Password = "";
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHP { get => noHP; set => noHP = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region methods
        //Method Cek Login
        public static Konsumen CekLogin(string username, string password)
        {
            string sql = "";

            sql = "select K.id, K.nama, K.email, K.no_hp, K.gender, K.tgl_lahir, K.saldo, K.username, K.password " +
                " from konsumens K " +
                " where username='" + username + "' AND password = " + password;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true) //selama ini masih ada data atau masih bisa membaca data
            {
                Konsumen k = new Konsumen();
                k.Id = hasil.GetValue(0).ToString();
                k.Nama = hasil.GetValue(1).ToString();
                k.Email = hasil.GetValue(2).ToString();
                k.NoHP = hasil.GetValue(3).ToString();
                k.Gender = hasil.GetValue(4).ToString();
                k.TglLahir = DateTime.Parse(hasil.GetValue(5).ToString());
                k.Saldo = double.Parse(hasil.GetValue(6).ToString());
                k.Username = hasil.GetValue(7).ToString();
                k.Password = hasil.GetValue(8).ToString();

                return k;
            }
            return null;
        }

        //Method Tambah Data
        public static void TambahData(Konsumen k)
        {
            string sql = "INSERT INTO konsumens (id, nama, email, no_hp, gender, tgl_lahir, saldo, username, password) " +
                        " values ('" + k.Id + "','" + k.Nama + "','" + k.Email + "','" + k.NoHP + "','" +
                        k.Gender + "','" + k.TglLahir.ToString("yyyy-MM-dd") + "','" + k.Saldo + "','" +
                        k.Username + "','" + k.Password + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode konsumen terakhir (kode terbesar)
            string sql = "select max(id) from konsumens";

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
        public static List<Konsumen> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select K.id, K.nama, K.email, K.no_hp, K.gender, K.tgl_lahir, K.saldo, K.username , K.password " +
                    " from konsumens K";
            }
            else
            {
                sql = "select K.id, K.nama, K.email, K.no_hp, K.gender, K.tgl_lahir, K.saldo, K.username, K.password " +
                    " from konsumens K" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Konsumen> listKonsumen = new List<Konsumen>(); //listnya berisi objek konsumen
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                Konsumen k = new Konsumen();
                k.Id = hasil.GetValue(0).ToString();
                k.Nama = hasil.GetValue(1).ToString();
                k.Email = hasil.GetValue(2).ToString();
                k.NoHP = hasil.GetValue(3).ToString();
                k.Gender = hasil.GetValue(4).ToString();
                k.TglLahir = DateTime.Parse(hasil.GetValue(5).ToString());
                k.Saldo = double.Parse(hasil.GetValue(6).ToString());
                k.Username = hasil.GetValue(7).ToString();
                k.Password = hasil.GetValue(8).ToString();

                listKonsumen.Add(k);
            }
            return listKonsumen;
        }

        //Method Ubah Data
        public static void UbahData(Konsumen k)
        {
            string sql = "update konsumens set nama='" + k.Nama +
                            "',email='" + k.Email +
                            "',no_hp='" + k.NoHP +
                            "',gender='" + k.Gender +
                            "',tgl_lahir='" + k.TglLahir.ToString("yyyy-MM-dd") +
                            "',saldo='" + k.Saldo +
                            "',username='" + k.Username +
                            "',password='" + k.Password + 
                            "' where id='" + k.Id + 
                            "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Hapus Data
        public static Boolean HapusData(Konsumen pK)
        {
            string perintah = "delete from konsumens where id='" + pK.Id + "'";

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
