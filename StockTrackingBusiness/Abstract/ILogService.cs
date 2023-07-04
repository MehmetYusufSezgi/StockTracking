using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Abstract
{
    public interface ILogService
    {
        void Add(Log log);
        List<Log> GetLogsByName(string logMessage);
        List<Log> GetAll();
    }
}
