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
    public partial class MainLogin : Form
    {
        CorpConnection corp;
        public MainLogin()
        {
            InitializeComponent();
            corp = new CorpConnection();
            corp.requestedLevel = "wifi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = corp.login(usernameTB.Text, passwordTB.Text);
            if (id != "")
            {
                new Main(id, this).Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Nome utente o password errati!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
