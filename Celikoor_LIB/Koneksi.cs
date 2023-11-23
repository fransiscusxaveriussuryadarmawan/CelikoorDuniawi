using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region constructors
        public Koneksi(string pServer, string pDb, string pUID, string pPWD)
        {
            string vConnString = "Server=" + pServer + ";Database=" + pDb + ";Uid=" + pUID + ";Pwd=" + pPWD + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = vConnString;

            //panggil method buat connect
            Connect();
        }
        #endregion

        #region properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region methods
        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];
            var settingSection = userSetting.Sections["Celikoor_Kelompok6.db"] as ClientSettingsSection;
            string vServer = settingSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string vDb = settingSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string vUID = settingSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string vPWD = settingSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string vConnString = "Server=" + vServer + ";Database=" + vDb + ";Uid=" + vUID + ";Pwd=" + vPWD + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = vConnString;

            Connect();
        }
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
                KoneksiDB.Close();

            KoneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            MySqlDataReader hasil = c.ExecuteReader();

            return hasil;
        }

        public static int JalankanPerintahNonQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            int hasil = c.ExecuteNonQuery();

            return hasil;
        }
        #endregion
    }
}
