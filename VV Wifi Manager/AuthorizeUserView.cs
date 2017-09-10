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
    public partial class AuthorizeUserView : Form
    {
        string reqCode;
        WifiUsers wifiUsers;
        Main _main;
        User user;
        Dictionary<string, string> req;

        public AuthorizeUserView(string code, Main main)
        {
            InitializeComponent();
            reqCode = code;
            _main = main;
            wifiUsers = new WifiUsers(_main.account_wifi);
        }

        private void AuthorizeUserView_Load(object sender, EventArgs e)
        {
            req = wifiUsers.getReq(reqCode);
            if (req.Count == 0)
            {
                MessageBox.Show("Non esiste nessuna richiesta con questo codice", "Errore");
                confirmBT.Enabled = false;
                return;
            }
            user = new User(req["UserId"], _main.account);
            if(req["Activated"] == "True")
            {
                confirmBT.Enabled = false;
                confirmBT.Text = "Richiesta già Attivata";
            }
            reqIDLabel.Text = "ID Richiesta: " + reqCode;
            nameTB.Text = user.angUser["Name"];
            surnameTB.Text = user.angUser["Surname"];
            classTB.Text = user.angUser["Class"];
            emailTB.Text = user.user["Email"];
        }

        private void confirmBT_Click(object sender, EventArgs e)
        {
            if(wifiUsers.authorizeUser(reqCode, user.user))
            {
                MessageBox.Show("Account Attivato!");
                AuthorizeUserView_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Errore");
            }
        }
    }
}
