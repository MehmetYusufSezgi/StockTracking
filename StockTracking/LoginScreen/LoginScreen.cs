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
            /*if (StaticCarrier.isFirstLoad)
            {
                rememberingMethod();
                StaticCarrier.isFirstLoad = false;
            }*/
        }
        ILoginDataService _loginDataService;

        public void rememberingMethod()
        {
            _loginDataService = new LoginDataManager(new EFLoginDataDAL());
            using (var context = new StockTrackingContext())
            {
                var loginhelp = context.LoginData.FirstOrDefault(p => p.IsCheckedLOGIN);
                if (loginhelp != null && loginhelp.IsCheckedLOGIN == true)
                {
                    CurrentUserName = loginhelp.CurrentNameLOGIN;
                    var userType = context.Users.FirstOrDefault(u => u.UserName == CurrentUserName);
                    if (userType.UserType == "admin")
                    {
                        this.Hide();
                        var adminGUIMenu = new AdminGUIMenu(CurrentUserName);
                        adminGUIMenu.ShowDialog();
                        adminGUIMenu.Dispose();
                    }
                    else if (userType.UserType == "kullanici")
                    {
                        this.Hide();
                        var userGUIMain = new UserGUIMain(CurrentUserName);
                        userGUIMain.ShowDialog();
                        userGUIMain.Dispose();
                    }
                }
            }
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
                        StaticCarrier.LoggedName = CurrentUserName;
                        /*if (chkboxRememberMe.Checked)
                        {
                            _loginDataService.Update(new LoginData
                            {
                                CurrentNameLOGIN = CurrentUserName,
                                CurrentPasswordLOGIN = password,
                                IsCheckedLOGIN = true
                            });
                        }
                        else
                        {
                            _loginDataService.Update(new LoginData
                            {
                                CurrentNameLOGIN = "",
                                CurrentPasswordLOGIN = "",
                                IsCheckedLOGIN = false
                            });
                        }*/
                        if (user.UserType == "admin")
                        {
                            this.Hide();
                            var adminGUIMenu = new AdminGUIMenu(CurrentUserName);
                            adminGUIMenu.ShowDialog();
                            adminGUIMenu.Dispose();
                        }
                        else if (user.UserType == "kullanici")
                        {
                            this.Hide();
                            var userGUIMain = new UserGUIMain(CurrentUserName);
                            userGUIMain.ShowDialog();
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

    }
}
