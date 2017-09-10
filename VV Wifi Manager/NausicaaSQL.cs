using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace VV_Wifi_Manager
{
    static class NausicaaSQL
    {
        public static MySqlConnection dbConnect(string db)
        {
            string server = "OMISSIS";
            string uid = "OMISSIS";
            string password = "OMISSIS";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            db + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return new MySqlConnection(connectionString);
        }

        public static void nonQuery(string query, MySqlConnection DB)
        {
            MySqlCommand cmd = new MySqlCommand(query, DB);
            cmd.ExecuteNonQuery();
        }

        public static List<dynamic> Query(string query, MySqlConnection DB)
        {
            List<dynamic> values = new List<dynamic>();
            MySqlCommand cmd = new MySqlCommand(query, DB);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                for(int i = 0; i <= reader.FieldCount-1; i++)
                {
                    dict.Add(reader.GetName(i), reader.GetString(i));
                }
                values.Add(dict);
            }
            reader.Close();
            return values;
        }

        public static string Hash(string stringToHash)
        {
            using (var sha1 = new SHA1Managed())
            {
                return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(stringToHash))).Replace("-", "").ToLower();
            }
        }
    }
}
