using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracking.AdminGUI
{
    public partial class AdminGUIMenu : Form
    {
        public AdminGUIMenu(string currentUserName)
        {
            InitializeComponent();
            txtboxMainUsername.Text = currentUserName;
            string name = currentUserName;
        }

        private void buttonUserControls_Click(object sender, EventArgs e)
        {
            UserGUIMain userGUIMain = new UserGUIMain(txtboxMainUsername.Text);
            userGUIMain.Show();
            this.Close();
        }
        

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdminControls_Click(object sender, EventArgs e)
        {
            string currentUserName = txtboxMainUsername.Text;
            AdminGUIMain adminGUIMain = new AdminGUIMain(currentUserName);
            adminGUIMain.Show();
            this.Close();
        }
    }
}
