using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Studio
    {
        private string id;
        private string nama;
        private string kapasitas;
        private JenisStudio jenisStudio;
        private Cinema jenisCinema;
        private int hargaWeekDay;
        private int hargaWeekEnd;

        #region constructors
        public Studio(string id, string nama, string kapasitas, JenisStudio jenisStudio, Cinema jenisCinema, int hargaWeekDay, int hargaWeekEnd)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kapasitas = kapasitas;
            this.JenisStudio = jenisStudio;
            this.JenisCinema = jenisCinema;
            this.HargaWeekDay = hargaWeekDay;
            this.HargaWeekEnd = hargaWeekEnd;
        }

        public Studio()
        {
            this.Id = "";
            this.Nama = "";
            this.Kapasitas = "";
            this.JenisStudio = new JenisStudio();
            this.JenisCinema = new Cinema();
            this.HargaWeekDay = 0;
            this.HargaWeekEnd = 0;
        }
        #endregion

        #region properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Kapasitas { get => kapasitas; set => kapasitas = value; }
        public JenisStudio JenisStudio { get => jenisStudio; set => jenisStudio = value; }
        public Cinema JenisCinema { get => jenisCinema; set => jenisCinema = value; }
        public int HargaWeekDay { get => hargaWeekDay; set => hargaWeekDay = value; }
        public int HargaWeekEnd { get => hargaWeekEnd; set => hargaWeekEnd = value; }
        #endregion

        #region methods
        //Method Tambah Data
        public static void TambahData(Studio s)
        {
            string sql = "INSERT INTO studios (id, nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend) " +
                        " values ('" + s.Id + "','" + s.Nama + "','" + s.Kapasitas + "','" + s.JenisStudio.Nama + "','" +
                        s.JenisCinema.NamaCabang + "','" + s.HargaWeekDay + "','" + s.HargaWeekEnd + "','" + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Generate Kode
        public static string GenerateKode()
        {
            //dapatkan kode konsumen terakhir (kode terbesar)
            string sql = "select max(id) from studios";

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
        public static List<Studio> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select S.id, S.nama, S.kapasitas, " + //studio
                "IKA.id, IKA.keterangan, " + //jenis studio
                "IKO.username, IKO.password, IKO.nama, IKO.jenis, " + // cinema
                "S.harga_weekday, S.harga_weekend " + // studio

                    "from studios S " +
                    "left join jenis_studios JS on S.jenis_studios_id = JS.nama " +
                    "left join cinemas C on S.cinemas_id = C.nama ";


            }
            else
            {
                sql = "select S.id, S.nama, S.kapasitas, " + //studio
                "IKA.id, IKA.keterangan, " + //jenis studio
                "IKO.username, IKO.password, IKO.nama, IKO.jenis, " + // cinema
                "S.harga_weekday, S.harga_weekend " + // studio

                    "from studios S " +
                    "left join jenis_studios JS on S.jenis_studios_id = JS.nama " +
                    "left join cinemas C on S.cinemas_id = C.nama " +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'"; ;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list untuk menampung data
            List<Studio> listStudio = new List<Studio>(); //listnya berisi objek konsumen
            while (hasil.Read() == true) //selama masih ada data atau masih bisa membaca data
            {
                //baca data dari MySqlDataReader dan simpan di objek
                JenisStudio jenisStudio = new JenisStudio();
                jenisStudio.Id = hasil.GetValue(3).ToString();
                jenisStudio.Nama = hasil.GetValue(4).ToString();
                jenisStudio.Deskripsi = hasil.GetValue(5).ToString();

                Cinema jenisCinema = new Cinema();
                jenisCinema.Id = hasil.GetValue(6).ToString();
                jenisCinema.NamaCabang = hasil.GetValue(7).ToString();
                jenisCinema.Alamat = hasil.GetValue(8).ToString();
                jenisCinema.TglDibuka = DateTime.Parse(hasil.GetValue(9).ToString());
                jenisCinema.Kota = hasil.GetValue(10).ToString();

                Studio s = new Studio();
                s.Id = hasil.GetValue(0).ToString();
                s.Nama = hasil.GetValue(1).ToString();
                s.Kapasitas = hasil.GetValue(2).ToString();
                s.JenisStudio = jenisStudio;
                s.JenisCinema = jenisCinema;
                s.HargaWeekDay = int.Parse(hasil.GetValue(11).ToString());
                s.HargaWeekEnd = int.Parse(hasil.GetValue(12).ToString());

                listStudio.Add(s);
            }
            return listStudio;
        }

        //Method Ubah Data
        public static void UbahData(Studio s)
        {
            string sql = "update studios set nama='" + s.Nama+
                            "',kapasitas='" + s.Kapasitas +
                            "',jenis_studios_id='" + s.JenisStudio +
                            "',cinemas_id='" + s.JenisCinema +
                            "',harga_weekday='" + s.HargaWeekDay +
                            "',harga_weekend='" + s.HargaWeekEnd +
                            "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        //Method Hapus Data
        public static Boolean HapusData(Studio pS)
        {
            string sql = "delete from studios where id='" + pS.Id + "'";

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
