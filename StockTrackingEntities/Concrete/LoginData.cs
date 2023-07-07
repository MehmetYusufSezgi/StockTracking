using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class LoginData:IEntity
    {
        public int LoginId { get; set; }
        public string CurrentNameLOGIN { get; set; }
        public string CurrentPasswordLOGIN { get; set; }
        public bool IsCheckedLOGIN { get; set; }
    }
}
