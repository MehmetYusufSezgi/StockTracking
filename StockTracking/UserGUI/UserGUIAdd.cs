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

namespace StockTracking.UserGUI
{
    public partial class UserGUIAdd : Form
    {
        public UserGUIAdd()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDAL());
            _categoryService = new CategoryManager(new EFCategoryDAL());
            _logService = new LogManager(new EFLogDAL());
        }
        IProductService _productService;
        ICategoryService _categoryService;
        ILogService _logService;
        private void LoadProducts()
        {
            dgvList.DataSource = _productService.GetAll();
            dgvList.Columns["ProductId"].Visible = false;
            dgvList.Columns["ProductPopularity"].Visible = false;
        }
        private void LoadCategories()
        {
            cmbboxCategory.DataSource = _categoryService.GetAll();
            cmbboxCategory.DisplayMember = "CategoryName";
            cmbboxCategory.ValueMember = "CategoryId";
        }
        ExceptionHandler exceptionHandler = new ExceptionHandler();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            exceptionHandler.TryCatcher(() =>
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cmbboxCategory.SelectedValue),
                    ProductName = txtboxProductName.Text,
                    StockCode = txtboxStock.Text,
                    Barcode = txtboxBarcode.Text,
                    ProductAmount = Convert.ToInt32(txtBoxAmount.Text),
                    ProductBuyingPrice = Convert.ToDecimal(txtboxBuyingPrice.Text),
                    ProductSellingPrice = Convert.ToDecimal(txtboxSellingPrice.Text)
                });
                LoadProducts();
                MessageBox.Show("Ürün Kaydedildi.");
                string currentName = NameCarrier.LoggedName;
                _logService.Add(new Log
                {
                    LogUser = currentName,
                    LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} ürün ekledi : {txtboxProductName.Text.ToUpper()} ({txtBoxAmount.Text}) "
                });
            });
        }

        private void UserGUIAdd_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }
    }
}
