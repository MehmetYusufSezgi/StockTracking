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

namespace StockTracking
{
    public partial class UserGUIMain : Form
    {
        public UserGUIMain(string currentUserName)
        {
            InitializeComponent();
            txtboxMainUsername.Text = currentUserName;
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
            loginScreen.Dispose();
        }
        private void buttonProductFunctions_Click(object sender, EventArgs e)
        {
            changeForm(new UserGUIOperations());
        }
    }
}
