using StockTrackingBusiness.Abstract;
using StockTrackingBusiness.Concrete;
using StockTrackingDataAccess.Concrete.EntityFramework;
using StockTrackingDataAccess.Concrete.NHiberbate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracking.UserGUI
{
    public partial class UserGUIList : Form
    {
        public UserGUIList()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDAL());
        }
        IProductService _productService;
        private void UserGUIList_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            dgvList.DataSource = _productService.GetAll();
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {
            //txtboxProductName

            if(!String.IsNullOrEmpty(txtboxSearch.Text))
            {
                dgvList.DataSource = _productService.GetProductsByName(txtboxSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
