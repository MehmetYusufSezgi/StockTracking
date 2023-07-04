using StockTrackingDataAccess.Abstract;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingDataAccess.Concrete.NHiberbate
{
    public class NhProductDAL : IProductDAL
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "NewItem",
                    CategoryId = 2,
                    StockCode = "15",
                    Barcode = "777",
                    ProductAmount = 5,
                    ProductBuyingPrice = 10,
                    ProductSellingPrice = 12,
                    ProductPopularity = 8
                }
            };
            return products;
        }

        public void Sell(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
