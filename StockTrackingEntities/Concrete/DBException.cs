using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class DBException:IEntity
    {
        public int DBExceptionId { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string DBExceptionUser { get; set; }
        [DisplayName("Hata Mesajı")]
        public string DBExceptionMessage { get; set; }
    }
}
