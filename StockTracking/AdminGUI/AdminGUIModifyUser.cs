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
    public partial class AdminGUIModifyUser : Form
    {
        public AdminGUIModifyUser()
        {
            InitializeComponent();
            _userService = new UserManager(new EFUserDAL());
            _logService = new LogManager(new EFLogDAL());
        }
        IUserService _userService;
        ILogService _logService;
        private void LoadUsers()
        {
            dgvList.DataSource = _userService.GetAll();
        }
        private void LoadUserTypes()
        {
            using (var context = new StockTrackingContext())
            {
                // Retrieve UserTypes from the Users table
                var userTypes = context.Users.Select(u => u.UserType).Distinct().ToList();

                // Create a BindingList<string> and add user types to it
                var bindingUserTypes = new BindingList<string>();
                foreach (var userType in userTypes)
                {
                    bindingUserTypes.Add(userType);
                }

                // Bind BindingList<string> to the ComboBox
                cmbboxUserType.DataSource = bindingUserTypes;
            }
        }


        private void buttonModify_Click(object sender, EventArgs e)
        {
            _userService.Update(new User
            {
                UserId = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                UserName = txtboxUserName.Text,
                UserMail = txtboxMail.Text,
                UserDBName = txtboxDBName.Text,
                Password = txtboxPassword.Text,
                PhoneNumber = txtboxPhoneNumber.Text,
                UserType = cmbboxUserType.SelectedValue.ToString()
            });
            LoadUsers();
            MessageBox.Show("Kullanıcı Güncellendi.");
            string currentName = NameCarrier.LoggedName;
            _logService.Add(new Log
            {
                LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} kullanıcı güncelledi : {txtboxUserName.Text.ToUpper()}"
            });
        }

        private void AdminGUIModifyUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUserTypes();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow != null)
            {
                LoadUserTypes();
                txtboxUserName.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
                txtboxMail.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
                txtboxDBName.Text = dgvList.CurrentRow.Cells[3].Value.ToString();
                txtboxPassword.Text = dgvList.CurrentRow.Cells[4].Value.ToString();
                txtboxPhoneNumber.Text = dgvList.CurrentRow.Cells[5].Value.ToString();
                cmbboxUserType.SelectedItem = dgvList.CurrentRow.Cells[6].Value.ToString();
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _userService.Delete(new User
            {
                UserId = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value.ToString()),
                UserName = txtboxUserName.Text,
                UserMail = txtboxMail.Text,
                UserDBName = txtboxDBName.Text,
                Password = txtboxPassword.Text,
                PhoneNumber = txtboxPhoneNumber.Text,
                UserType = cmbboxUserType.SelectedValue.ToString()
            });
            MessageBox.Show("Kullanıcı Silindi.");
            LoadUsers();
            string currentName = NameCarrier.LoggedName;
            _logService.Add(new Log
            {
                LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} kullanıcı sildi : {txtboxUserName.Text.ToUpper()}"
            });
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxSearch.Text))
            {
                dgvList.DataSource = _userService.GetUsersByName(txtboxSearch.Text);
            }
            else
            {
                LoadUsers();
            }
        }
    }
}
