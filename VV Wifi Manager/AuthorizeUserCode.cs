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
    public partial class AuthorizeUserCode : Form
    {
        Main _main;
        public AuthorizeUserCode(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void AuthorizeUserCode_Load(object sender, EventArgs e)
        {
            codeTB.Focus();
        }

        private void checkBT_Click(object sender, EventArgs e)
        {
            AuthorizeUserView auth = new AuthorizeUserView(codeTB.Text, _main);
            auth.MdiParent = _main;
            auth.Show();
        }
    }
}
