using StockTrackingDataAccess.Abstract;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingDataAccess.Concrete.EntityFramework
{
    public class EFLoginDataDAL : EFEntityRepositoryBase<LoginData, StockTrackingContext>, ILoginDataDAL
    {
    }
}
