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
    public partial class UserGUISell : Form
    {
        public UserGUISell()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDAL());
            _categoryService = new CategoryManager(new EFCategoryDAL());
            _logService = new LogManager(new EFLogDAL());
        }
        IProductService _productService;
        ICategoryService _categoryService;
        ILogService _logService;
        ExceptionHandler exceptionHandler = new ExceptionHandler();
        private void buttonSell_Click(object sender, EventArgs e)
        {
            DataUpdating();
            exceptionHandler.TryCatcher(() =>
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cmbboxCategory.SelectedValue),
                    ProductName = txtboxProductName.Text,
                    StockCode = txtboxStock.Text,
                    Barcode = txtboxBarcode.Text,
                    ProductAmount = (Convert.ToInt32(txtBoxAmount.Text) - 1),
                    ProductBuyingPrice = Convert.ToDecimal(txtboxBuyingPrice.Text),
                    ProductSellingPrice = Convert.ToDecimal(txtboxSellingPrice.Text)
                });
                MessageBox.Show("Ürün Satıldı.");
                DataUpdating();
                LoadProducts();
                string currentName = NameCarrier.LoggedName;
                _logService.Add(new Log
                {
                    LogUser = currentName,
                    LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} bir ürün sattı : {txtboxProductName.Text.ToUpper()}"
                });
            });
        }

        private void UserGUISell_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }
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

        private void txtboxProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSellingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxBuyingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCategories();
            DataUpdating();
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxSearch.Text))
            {
                dgvList.DataSource = _productService.GetProductsByName(txtboxSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }
        private void DataUpdating()
        {
            if (dgvList.CurrentRow != null)
            {
                txtboxProductName.Text = dgvList.CurrentRow.Cells[1].Value.ToString();

                if (!Convert.IsDBNull(dgvList.CurrentRow.Cells[2].Value))
                {
                    txtboxStock.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    txtboxStock.Text = string.Empty;
                }

                txtboxBarcode.Text = dgvList.CurrentRow.Cells[3].Value.ToString();

                int categoryId;
                if (int.TryParse(dgvList.CurrentRow.Cells[4].Value.ToString(), out categoryId))
                {
                    cmbboxCategory.SelectedValue = categoryId;
                }

                txtBoxAmount.Text = dgvList.CurrentRow.Cells[5].Value.ToString();
                txtboxSellingPrice.Text = dgvList.CurrentRow.Cells[6].Value.ToString();
                txtboxBuyingPrice.Text = dgvList.CurrentRow.Cells[7].Value.ToString();
            }
        }
    }
}
