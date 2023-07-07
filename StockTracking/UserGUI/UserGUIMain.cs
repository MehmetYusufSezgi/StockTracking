using StockTracking.AdminGUI;
using StockTracking.UserGUI;
using StockTrackingDataAccess.Concrete.EntityFramework;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StockTracking.LoginScreen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            using(var context = new StockTrackingContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName.ToLower() == StaticCarrier.LoggedName.ToLower());
                if(user.UserType == "admin")
                {
                    this.Hide();
                    var adminGUIMenu = new AdminGUIMenu(StaticCarrier.LoggedName);
                    adminGUIMenu.ShowDialog();
                    adminGUIMenu.Dispose();
                }
                else
                {
                    this.Hide();
                    var loginScreen = new LoginScreen();
                    loginScreen.ShowDialog();
                    loginScreen.Dispose();
                }
            }

        }
        private void buttonProductFunctions_Click(object sender, EventArgs e)
        {
            changeForm(new UserGUIOperations());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
