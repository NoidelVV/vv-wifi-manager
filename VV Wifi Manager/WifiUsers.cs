using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net;

namespace VV_Wifi_Manager
{
    class WifiUsers
    {
        MySqlConnection account_wifi;
        public List<dynamic> wifiUsers;
        public List<dynamic> wifiRequests;

        public WifiUsers(MySqlConnection _account_wifi)
        {
            account_wifi = _account_wifi;
            loadRequests();
            loadUsers();
        }

        private void loadUsers()
        {
            wifiUsers = NausicaaSQL.Query("OMISSIS", account_wifi);
        }

        private void loadRequests()
        {
            wifiRequests = NausicaaSQL.Query("OMISSIS", account_wifi);
        }

        public void reloadUsers()
        {
            loadUsers();
        }

        public void reloadRequests()
        {
            loadRequests();
        }

        public void deleteUser(string ID)
        {
            NausicaaSQL.nonQuery("OMISSIS", account_wifi);
            NausicaaSQL.nonQuery("OMISSIS", account_wifi);
            reloadUsers();
        }

        public bool authorizeUser(string reqID, Dictionary<string, string> user)
        {
            var q = NausicaaSQL.Query("OMISSIS", account_wifi);
            if(q.Count == 0)
            {
                return false;
            }
            Dictionary<string, string> req = q[0];
            if(req["Activated"] == "True")
            {
                return false;
            }
            NausicaaSQL.nonQuery("OMISSIS", account_wifi);
            NausicaaSQL.nonQuery("OMISSIS", account_wifi);
            WebClient wb = new WebClient();
            wb.DownloadData("https://OMISSIS.noidelvv.it/shared/wifi_request/req/send_confirm.php?id=" + user["ID"]);
            return true;
        }

        public Dictionary<string, string> getReq(string reqID)
        {
            var q = NausicaaSQL.Query("OMISSIS", account_wifi);
            if(q.Count != 0)
            {
                return q[0];
            }
           else
            {
                return new Dictionary<string, string>();
            }
        }
    }
}
