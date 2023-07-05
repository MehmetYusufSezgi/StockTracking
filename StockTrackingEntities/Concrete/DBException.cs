using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class DBException:IEntity
    {
        public int DBExceptionId { get; set; }
        public string DBExceptionUser { get; set; }
        public string DBExceptionMessage { get; set; }
    }
}
