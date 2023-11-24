using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Pegawai
    {
        private string id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string role;

        #region constructors
        public Pegawai(string id, string nama, string email, string username, string password, string role)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public Pegawai()
        {
            this.Id = "";
            this.Nama = "";
            this.Email = "";
            this.Username = "";
            this.Password = "";
            this.Role = "";
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        #endregion

        #region methods
        //Method Cek Login
        public static Pegawai CekLogin(string username, string password)
        {
            string sql = "";

            sql = "select P.id, P.nama, P.email, P.username, P.password, P.roles " +
                " from pegawais P " +
                " where username='" + username + "' AND password = " + password;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true) //selama ini masih ada data atau masih bisa membaca data
            {
                Pegawai p = new Pegawai();
                p.Id = hasil.GetValue(0).ToString();
                p.Nama = hasil.GetValue(1).ToString();
                p.Email = hasil.GetValue(2).ToString();
                p.Username = hasil.GetValue(3).ToString();
                p.Password = hasil.GetValue(4).ToString();
                p.Role = hasil.GetValue(5).ToString();

                return p;
            }
            return null;
        }

        //Method Tambah Data
        public static void TambahData(Pegawai p)
        {
            string sql = "INSERT INTO pegawais (id, nama, email, username, password, roles) " +
                        " values ('" + p.Id + "','" + p.Nama + "','" + p.Email + "','" + p.Username + "','" +
                        p.Password + "','" + p.Role + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode konsumen terakhir (kode terbesar)
            string sql = "select max(id) from pegawais";

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
        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select P.id, P.nama, P.email, P.username, P.password, P.roles " +
                    " from pegawais P";
            }
            else
            {
                sql = "select P.id, P.nama, P.email, P.username, P.password, P.roles " +
                    " from pegawais P" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Pegawai> listPegawai = new List<Pegawai>(); //listnya berisi objek pegawai
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                Pegawai p = new Pegawai();
                p.Id = hasil.GetValue(0).ToString();
                p.Nama = hasil.GetValue(1).ToString();
                p.Email = hasil.GetValue(2).ToString();
                p.Username = hasil.GetValue(3).ToString();
                p.Password = hasil.GetValue(4).ToString();
                p.Role = hasil.GetValue(5).ToString();

                listPegawai.Add(p);
            }
            return listPegawai;
        }

        //Method Hapus Data
        public static Boolean HapusData(Pegawai pP)
        {
            string perintah = "delete from pegawais where id='" + pP.Id + "'";

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
