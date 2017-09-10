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
    public partial class UsersList : Form
    {
        Main _main;
        WifiUsers users;
        public UsersList(Main main)
        {
            InitializeComponent();
            _main = main;
            users = new WifiUsers(main.account_wifi);
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            usersData.Rows.Clear();
            foreach (Dictionary<string, string> user in users.wifiUsers)
            {
                int index = usersData.RowCount;
                Dictionary<string, string> angUser = User.getUserInfo(user["id"], _main.account);
                usersData.Rows.Add(user["id"], angUser["Name"] + " " + angUser["Surname"], angUser["Class"], user["username"]);
                usersData.Rows[index].ContextMenuStrip = itemsMenu;
            }
        }

        private void aggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users.reloadUsers();
            UsersList_Load(new object(), new EventArgs());
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users.deleteUser(usersData.CurrentRow.Cells[0].Value.ToString());
            UsersList_Load(new object(), new EventArgs());
        }
    }
}
