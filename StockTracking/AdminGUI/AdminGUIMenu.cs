using StockTracking.UserGUI;
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
        private Form currentForm = null;
        private void changeForm(Form subForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panelSubForm.Controls.Add(subForm);
            panelSubForm.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
        }

        private void buttonUserControls_Click(object sender, EventArgs e)
        {
            string currentUserName = txtboxMainUsername.Text;
            changeForm(new UserGUIOperations());
        }
        

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
            loginScreen.Dispose();
        }

        private void buttonAdminControls_Click(object sender, EventArgs e)
        {
            changeForm(new AdminGUIOperations());
        }

        private void buttonExceptions_Click(object sender, EventArgs e)
        {
            changeForm(new AdminGUILognExc());
        }

        private void picboxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
