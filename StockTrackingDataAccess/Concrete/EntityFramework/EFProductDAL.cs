using StockTrackingDataAccess.Abstract;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingDataAccess.Concrete.EntityFramework
{
    public class EFProductDAL : EFEntityRepositoryBase<Product, StockTrackingContext>,IProductDAL
    {
        
    }
}
