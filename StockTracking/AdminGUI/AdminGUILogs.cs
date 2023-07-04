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
    public partial class AdminGUILogs : Form
    {
        public AdminGUILogs()
        {
            InitializeComponent();
            _logService = new LogManager(new EFLogDAL());
        }
        ILogService _logService;

        private void AdminGUILogs_Load(object sender, EventArgs e)
        {
            LoadLogs();
            dgvList.Columns[0].Visible = false;
        }
        /*private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxSearch.Text))
            {
                dgvList.DataSource = _logService.GetLogsByName(txtboxSearch.Text);
            }
            else
            {
                LoadLogs();
            }
        }*/

        private void LoadLogs()
        {
            dgvList.DataSource = _logService.GetAll();
        }
    }
}
