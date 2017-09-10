using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace VV_Wifi_Manager
{
   class CorpConnection
    {
        static public MySqlConnection DB;
        public string requestedLevel;

        public CorpConnection()
        {
            DB = NausicaaSQL.dbConnect("OMISSIS");
            DB.Open();
        }

        public string login(string username, string password)
        {
            var q = NausicaaSQL.Query("OMISSIS", DB);
            if(q.Count != 0 && (q[0]["Privileges"] == requestedLevel || q[0]["Privileges"] == "admin"))
            {
                return q[0]["ID"];
            }
            else
            {
                return "";
            }
        }

        protected void Dispose(bool disposing)
        {
            DB.Close();
        }
    }
}
