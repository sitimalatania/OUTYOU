using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UTS
{
    public class KoneksiDB
    {
        private MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=uts;");

        public bool Connect()
        {
            try
            {
                databaseConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                databaseConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public MySqlDataReader Query(string s)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(s, databaseConnection);
                cmd.CommandTimeout = 30;
                return cmd.ExecuteReader();
            } catch(Exception ex)
            {
                return null;
            }
        }

        public bool Execute(string s)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(s, databaseConnection);
                cmd.CommandTimeout = 30;
                return cmd.ExecuteReader() != null;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static KoneksiDB Koneksi
        {
            get { return koneksi; }
        }
        private static KoneksiDB koneksi = new KoneksiDB();
    }
}
