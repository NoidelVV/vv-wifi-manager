using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VV_Wifi_Manager
{
    public partial class Main : Form
    {
        string _userID;
        MainLogin _login;
        public MySqlConnection corp;
        public MySqlConnection account;
        public MySqlConnection account_wifi;
        public Dictionary<string, string> currentUser;

        public Main(string id, MainLogin login)
        {
            InitializeComponent();
            _userID = id;
            _login = login;
            corp = NausicaaSQL.dbConnect("OMISSIS");
            account = NausicaaSQL.dbConnect("OMISSIS");
            account_wifi = NausicaaSQL.dbConnect("OMISSIS");
            corp.Open();
            account.Open();
            account_wifi.Open();
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            corp.Close();
            account.Close();
            account_wifi.Close();
            _login.Show();
        }

        private void visualizzaElencoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void utentiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList(this);
            usersList.MdiParent = this;
            usersList.Show();
        }

        private void richiesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestsList requestsList = new RequestsList(this);
            requestsList.MdiParent = this;
            requestsList.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var q = NausicaaSQL.Query("OMISSIS", corp);
            currentUser = q[0];
            welcomeLabel.Text = "Benvenuto " + currentUser["Name"] + " " + currentUser["Surname"];
        }

        private void aggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizeUserCode auth = new AuthorizeUserCode(this);
            auth.MdiParent = this;
            auth.Show();
        }

        private void utentiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creato da Vittorio Grasso per l'uso esclusivo da parte di Liceo Scientifico Vittorio Veneto.", "Informazioni", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
