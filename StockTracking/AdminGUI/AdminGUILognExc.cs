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
    public partial class AdminGUILognExc : Form
    {
        public AdminGUILognExc()
        {
            InitializeComponent();
            _userService = new UserManager(new EFUserDAL());
            _logService = new LogManager(new EFLogDAL());
            _exceptionService = new DBExceptionManager(new EFDBExceptionDAL());
        }
        IUserService _userService;
        ILogService _logService;
        IDBExceptionService _exceptionService;

        private void LoadLognEx()
        {
            dgvListException.DataSource = _exceptionService.GetAll();
            dgvListLog.DataSource = _logService.GetAll();
        }
        private void AdminGUIListUser_Load(object sender, EventArgs e)
        {
            LoadLognEx();
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxSearch.Text))
            {
                dgvListException.DataSource = _exceptionService.GetExceptionsByName(txtboxSearch.Text);
                dgvListLog.DataSource = _logService.GetLogsByName(txtboxSearch.Text);
            }
            else
            {
                LoadLognEx();
            }
        }

    }
}
