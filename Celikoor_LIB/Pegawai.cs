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
        #endregion
    }
}
