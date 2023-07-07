using StockTrackingBusiness.Abstract;
using StockTrackingDataAccess.Abstract;
using StockTrackingDataAccess.Concrete.EntityFramework;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void Add(Product product)
        {
            _productDAL.Add(product);
        }

        public void Delete(Product product)
        {
            _productDAL.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDAL.GetAll();
        }

        public Product GetProductByBarcode(string barcode)
        {
            return _productDAL.Get(p=>p.Barcode.Equals(barcode));
        }

        public List<Product> GetProductsByBarcode(string barcode)
        {
            return _productDAL.GetAll(p=>p.Barcode.ToLower().Contains(barcode.ToLower()));
        }
        public void Update(Product product)
        {
            _productDAL.Update(product);
        }

    }
}
