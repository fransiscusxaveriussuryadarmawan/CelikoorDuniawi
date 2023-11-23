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

        #endregion
    }
}
