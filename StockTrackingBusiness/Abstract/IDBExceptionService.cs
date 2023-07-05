using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Abstract
{
    public interface IDBExceptionService
    {
        void Add(DBException dbexception);
        List<DBException> GetAll();
    }
}
