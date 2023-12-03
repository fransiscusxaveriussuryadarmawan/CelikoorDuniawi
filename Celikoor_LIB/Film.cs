using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Celikoor_LIB
{
    public class Film
    {
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private Kelompok kelompok;
        private string bahasa;
        private bool adaSubIndo;
        private string coverImage; //di modul varchar
        private double nominalDiskon;

        #region properties
        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok Kelompok { get => kelompok; set => kelompok = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public bool AdaSubIndo { get => adaSubIndo; set => adaSubIndo = value; }
        public string CoverImage { get => coverImage; set => coverImage = value; }
        public double NominalDiskon { get => nominalDiskon; set => nominalDiskon = value; }
        #endregion

        #region constructors
        public Film(int id, string judul, string sinopsis, int tahun, int durasi, Kelompok kelompok, string bahasa, bool adaSubIndo, string coverImage, double nominalDiskon)
        {
            this.Id = id;
            this.Judul = judul;
            this.Sinopsis = sinopsis;
            this.Tahun = tahun;
            this.Durasi = durasi;
            this.Kelompok = kelompok;
            this.Bahasa = bahasa;
            this.AdaSubIndo = adaSubIndo;
            this.CoverImage = coverImage;
            this.NominalDiskon = nominalDiskon;
        }

        public Film()
        {
            this.Id = 0;
            this.Judul = "";
            this.Sinopsis = "";
            this.Tahun = 0;
            this.Durasi = 0;
            this.Kelompok = new Kelompok();
            this.Bahasa = "";
            this.AdaSubIndo = false;
            this.CoverImage = "";
            this.NominalDiskon = 0;
        }
        #endregion

        #region methods
        public static List<Film> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "Select * from films";
            }
            else
            {
                sql = "select * from films where " + filter + "like '%" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Film> listFilm = new List<Film>();
            while (hasil.Read() == true)
            {
                Film tampungFilm = new Film();
                tampungFilm.Id = int.Parse(hasil.GetValue(0).ToString());
                tampungFilm.Judul = hasil.GetValue(1).ToString();
                tampungFilm.Sinopsis = hasil.GetValue(2).ToString();
                tampungFilm.Tahun = int.Parse(hasil.GetValue(3).ToString());
                tampungFilm.Durasi = int.Parse(hasil.GetValue(4).ToString());

                tampungFilm.Kelompok.Id = int.Parse(hasil.GetValue(5).ToString());
                //bikin method BacaDataAmbil untuk sini

                Film tampung = new Film(tampungKode, tampungNama);
                listFilm.Add(tampung);
            }
            return listFilm;
        }

        public static void TambahData(Film f)
        {
            string sql = "INSERT INTO films(id, judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, cover_image, diskon_nominal) " +
                "VALUES ('"+f.Id+"', '"+f.Judul+"', '"+f.Sinopsis+"', '"+f.Tahun+"', '"+f.Durasi+"', '"+f.Kelompok.Id+"', '"+f.Bahasa+"', '"+f.AdaSubIndo+"', '"+f.CoverImage+"', '"+f.NominalDiskon+"');";
        }

        public static Boolean HapusData(Film f)
        {
            string sql = "delete from films where id='" + f.Id + "'";

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

        public static string GenerateKode()
        {
            //dapatkan kode genre terakhir (kode terbesar)
            string sql = "select max(id) from films";

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
        #endregion
    }
}
