using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class Log:IEntity
    {
        public int LogId { get; set; }
        public string LogMessage { get; set; }

    }
}
