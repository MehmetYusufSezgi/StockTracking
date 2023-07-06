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
    public partial class AdminGUIMain : Form
    {
        public AdminGUIMain(string currentUserName)
        {
            InitializeComponent();
            txtboxMainUsername.Text = currentUserName;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //Application.OpenForms
        }
        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            changeForm(new AdminGUIListUser());
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            changeForm(new AdminGUIAddUser());
        }

        private void buttonModifyUser_Click(object sender, EventArgs e)
        {
            changeForm(new AdminGUIModifyUser());
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            changeForm(new AdminGUILogs());
        }
    }
}
