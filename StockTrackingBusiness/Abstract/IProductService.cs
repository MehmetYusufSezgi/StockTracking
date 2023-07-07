using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        Product GetProductByBarcode(string barcode);
        List<Product> GetProductsByBarcode(string barcode);
        void Update(Product product);
    }
}
