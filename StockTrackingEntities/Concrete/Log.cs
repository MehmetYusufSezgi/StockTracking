using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class Log:IEntity
    {
        public int LogId { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string LogUser { get; set; }
        [DisplayName("Kayıt Mesajı")]
        public string LogMessage { get; set; }

    }
}
