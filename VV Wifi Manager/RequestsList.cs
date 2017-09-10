using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VV_Wifi_Manager
{
    public partial class RequestsList : Form
    {
        Main _main;
        WifiUsers users;

        public RequestsList(Main main)
        {
            InitializeComponent();
            _main = main;
            users = new WifiUsers(main.account_wifi);
        }

        private void RequestsList_Load(object sender, EventArgs e)
        {
            usersData.Rows.Clear();
            foreach (Dictionary<string, string> req in users.wifiRequests)
            {
                int index = usersData.RowCount;
                usersData.Rows.Add(req["ID"],req["UserId"], req["Name"], req["Class"], (req["Activated"] == "True" ? "Attivato" : "In Attesa"));
                usersData.Rows[index].ContextMenuStrip = itemsMenu;
            }
        }

        private void aggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users.reloadRequests();
            RequestsList_Load(new object(), new EventArgs());
        }
    }
}
