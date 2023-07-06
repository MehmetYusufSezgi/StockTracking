using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }
        [DisplayName("Stok Kodu")]
        public string StockCode { get; set; }
        [DisplayName("Barkodu")]
        public string Barcode { get; set; }
        [DisplayName("Kategorisi")]
        public int CategoryId { get; set; }
        [DisplayName("Ürün Miktarı")]
        public int ProductAmount { get; set; }
        [DisplayName("Satış Fiyatı")]
        public decimal ProductSellingPrice { get; set; }
        [DisplayName("Alış Fiyatı")]
        public decimal ProductBuyingPrice { get; set; }
        public int ProductPopularity { get; set; }
    }
}
