using StockTrackingBusiness;
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

namespace StockTracking.AdminGUI
{
    public partial class AdminGUIAddUser : Form
    {
        public AdminGUIAddUser()
        {
            InitializeComponent();
            _userService = new UserManager(new EFUserDAL());
            _logService = new LogManager(new EFLogDAL());
            
        }
        IUserService _userService;
        ILogService _logService;
        private void AdminGUIAddUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUserTypes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUsers()
        {
            dgvList.DataSource = _userService.GetAll();
            dgvList.Columns["UserId"].Visible = false;
        }
        private void LoadUserTypes()
        {
            using (var context = new StockTrackingContext())
            {
                // Retrieve UserTypes from the Users table
                var userTypes = context.Users.Select(u => u.UserType).Distinct().ToList();

                // Bind UserTypes to the ComboBox
                cmbboxUserType.DataSource = userTypes;
            }
        }
        ExceptionHandler exceptionHandler = new ExceptionHandler();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            exceptionHandler.TryCatcher(() =>
            {
                _userService.Add(new User
                {
                    UserName = txtboxUserName.Text,
                    UserMail = txtboxMail.Text,
                    UserDBName = txtboxDBName.Text,
                    Password = txtboxPassword.Text,
                    PhoneNumber = txtboxPhoneNumber.Text,
                    UserType = cmbboxUserType.SelectedValue.ToString()
                });
                LoadUsers();
                MessageBox.Show("Kullanıcı Eklendi.");
                string currentName = NameCarrier.LoggedName;
                _logService.Add(new Log
                {
                    LogUser = currentName,
                    LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} kullanıcı ekledi : {txtboxUserName.Text.ToUpper()}"
                });
            });
        }
    }
}
