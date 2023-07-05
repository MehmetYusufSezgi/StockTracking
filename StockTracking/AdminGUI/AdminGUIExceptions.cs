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
    public partial class AdminGUIExceptions : Form
    {
        public AdminGUIExceptions()
        {
            InitializeComponent();
            _exceptionService = new DBExceptionManager(new EFDBExceptionDAL());
        }
        IDBExceptionService _exceptionService;
        private void LoadExceptions()
        {
            dgvList.DataSource = _exceptionService.GetAll();
        }
        private void AdminGUIExceptions_Load(object sender, EventArgs e)
        {
            LoadExceptions();
        }
    }
}
