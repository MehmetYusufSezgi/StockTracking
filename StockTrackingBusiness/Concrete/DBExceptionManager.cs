using StockTrackingBusiness.Abstract;
using StockTrackingDataAccess.Abstract;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Concrete
{
    public class DBExceptionManager : IDBExceptionService
    {
        private IDBExceptionDAL _exceptionDAL;
        public DBExceptionManager(IDBExceptionDAL exceptionDAL)
        {
            _exceptionDAL = exceptionDAL;
        }

        public void Add(DBException dbexception)
        {
            _exceptionDAL.Add(dbexception);
        }

        public List<DBException> GetAll()
        {
            return _exceptionDAL.GetAll();
        }
    }
}
