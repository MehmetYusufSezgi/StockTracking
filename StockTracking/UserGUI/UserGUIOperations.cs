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
    public partial class UserGUIOperations : Form
    {
        public UserGUIOperations()
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
            string barcode = txtboxBarcode.Text;
            Product existingProduct = _productService.GetProductByBarcode(barcode);
            exceptionHandler.TryCatcher(() =>
            {
                if (existingProduct != null)
                {
                    _productService.Update(new Product
                    {
                        ProductId = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                        CategoryId = Convert.ToInt32(cmbboxCategory.SelectedValue),
                        ProductName = txtboxProductName.Text,
                        StockCode = txtboxStock.Text,
                        Barcode = txtboxBarcode.Text,
                        ProductAmount = Convert.ToInt32(txtBoxAmount.Text),
                        ProductBuyingPrice = Convert.ToDecimal(txtboxBuyingPrice.Text),
                        ProductSellingPrice = Convert.ToDecimal(txtboxSellingPrice.Text)
                    });
                    MessageBox.Show("Ürün Güncellendi.");
                    LoadProducts();
                    string currentName = NameCarrier.LoggedName;
                    _logService.Add(new Log
                    {
                        LogUser = currentName,
                        LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} ürün güncelledi : {txtboxProductName.Text.ToUpper()}"
                    });
                }
                else
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
                }
            });
        }

        private void UserGUIAdd_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            exceptionHandler.TryCatcher(() =>
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cmbboxCategory.SelectedValue),
                    ProductName = txtboxProductName.Text,
                    StockCode = txtboxStock.Text,
                    Barcode = txtboxBarcode.Text,
                    ProductAmount = Convert.ToInt32(txtBoxAmount.Text),
                    ProductBuyingPrice = Convert.ToDecimal(txtboxBuyingPrice.Text),
                    ProductSellingPrice = Convert.ToDecimal(txtboxSellingPrice.Text)
                });
                MessageBox.Show("Ürün Silindi.");
                LoadProducts();
                string currentName = NameCarrier.LoggedName;
                _logService.Add(new Log
                {
                    LogUser = currentName,
                    LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} ürün sildi : {txtboxProductName.Text.ToUpper()}"
                });
            });

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCategories();
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

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxSearch.Text))
            {
                dgvList.DataSource = _productService.GetProductsByBarcode(txtboxSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cmbboxCategory.SelectedValue),
                ProductName = txtboxProductName.Text,
                StockCode = txtboxStock.Text,
                Barcode = txtboxBarcode.Text,
                ProductAmount = Convert.ToInt32(txtBoxAmount.Text)-Convert.ToInt32(txtboxSellingAmount.Text),
                ProductBuyingPrice = Convert.ToDecimal(txtboxBuyingPrice.Text),
                ProductSellingPrice = Convert.ToDecimal(txtboxSellingPrice.Text)
            });
            MessageBox.Show("Ürün Satıldı.");
            LoadProducts();
            string currentName = NameCarrier.LoggedName;
            _logService.Add(new Log
            {
                LogUser = currentName,
                LogMessage = $"{DateTime.Now} tarihinde {currentName.ToUpper()} ürün satıldı : {txtboxProductName.Text.ToUpper()}"
            });
        }
    }
}
