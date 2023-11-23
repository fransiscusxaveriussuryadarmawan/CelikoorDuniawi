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

                //return u;
            }
            return null;
        }
        #endregion
    }
}
