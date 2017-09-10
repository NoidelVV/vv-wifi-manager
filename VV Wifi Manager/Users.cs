using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VV_Wifi_Manager
{
    class User
    {
        public Dictionary<string, string> angUser;
        public Dictionary<string, string> user;

        public User(string ID, MySqlConnection account)
        {
            var q = NausicaaSQL.Query("OMISSIS", account);
            var q2 = NausicaaSQL.Query("OMISSIS", account);
            angUser = q[0];
            user = q2[0];
        }

        public static Dictionary<string, string> getUserInfo(string ID, MySqlConnection DB)
        {
            var user = NausicaaSQL.Query("OMISSIS", DB);
            if(user.Count != 0)
            {
                return user[0];
            }
            else
            {
                return new Dictionary<string, string>();
            }
        }
    }
}
