using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [DisplayName("Mail Adresi")]
        public string UserMail { get; set; }
        [DisplayName("Şirket İçi Adı")]
        public string UserDBName { get; set; }
        [DisplayName("Şifresi")]
        public string Password { get; set; }
        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [DisplayName("Kullanıcı Tipi")]
        public string UserType { get; set; }
    }
}
