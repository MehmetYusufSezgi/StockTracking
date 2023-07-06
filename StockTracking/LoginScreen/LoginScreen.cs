using StockTracking.AdminGUI;
using StockTrackingBusiness.Abstract;
using StockTrackingBusiness.Concrete;
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

//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBStockTrack;Integrated Security=True
namespace StockTracking
{
    public partial class LoginScreen : Form
    {
        public string CurrentUserName { get; private set; }
        public LoginScreen()
        {
            InitializeComponent();
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            if (ValidateUserCredentials(username, password))
            {
                using (var context = new StockTrackingContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.UserName.ToLower() == username.ToLower());

                    if (user != null)
                    {
                        CurrentUserName = user.UserName;
                        if (user.UserType == "admin")
                        {
                            this.Hide();
                            var adminGUIMain = new AdminGUIMenu(CurrentUserName);
                            adminGUIMain.ShowDialog();
                            NameCarrier.LoggedName = CurrentUserName;
                            adminGUIMain.Dispose();
                        }
                        else if (user.UserType == "kullanici")
                        {
                            this.Hide();
                            var userGUIMain = new UserGUIMain(CurrentUserName);
                            userGUIMain.ShowDialog();
                            NameCarrier.LoggedName = CurrentUserName;
                            userGUIMain.Dispose();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }            
        }
        public bool ValidateUserCredentials(string username, string password)
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName.ToLower() == username.ToLower() && u.Password.ToLower() == password.ToLower());
                //Kullanıcı bulundu
                return user != null;
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
