using StockTrackingDataAccess.Abstract;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBException = StockTrackingEntities.Concrete.DBException;

namespace StockTrackingDataAccess.Concrete.EntityFramework
{
    public class EFDBExceptionDAL : EFEntityRepositoryBase<DBException, StockTrackingContext>, IDBExceptionDAL
    {
        
    }
}
