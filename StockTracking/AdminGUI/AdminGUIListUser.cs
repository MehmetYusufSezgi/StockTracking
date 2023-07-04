using StockTrackingBusiness.Abstract;
using StockTrackingBusiness.Concrete;
using StockTrackingDataAccess.Concrete.EntityFramework;
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
    public partial class AdminGUIListUser : Form
    {
        public AdminGUIListUser()
        {
            InitializeComponent();
            _userService = new UserManager(new EFUserDAL());
        }
        IUserService _userService;

        private void LoadUsers()
        {
            dgvList.DataSource = _userService.GetAll();
        }
        private void AdminGUIListUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
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
