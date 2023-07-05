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
    public class LogManager : ILogService
    {
        private ILogDAL _logDAL;
        public LogManager(ILogDAL logDAL)
        {
            _logDAL = logDAL;
        }

        public void Add(Log log)
        {
            _logDAL.Add(log);
        }

        public List<Log> GetAll()
        {
            return _logDAL.GetAll();
        }

        public object GetLogsByName(string logUser)
        {
            return _logDAL.GetAll(p => p.LogUser.ToLower().Contains(logUser.ToLower()));
        }

        List<Log> ILogService.GetLogsByName(string logMessage)
        {
            throw new NotImplementedException();
        }
    }
}
