using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    [Table("LoginData")]
    public class LoginData:IEntity
    {
        [Key]
        public int LoginId { get; set; }
        public string CurrentNameLOGIN { get; set; }
        public string CurrentPasswordLOGIN { get; set; }
        public bool IsCheckedLOGIN { get; set; }
    }
}
