using StockTrackingEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingEntities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string StockCode { get; set; }
        public string Barcode { get; set; }
        public int CategoryId { get; set; }
        public int ProductAmount { get; set; }
        public decimal ProductSellingPrice { get; set; }
        public decimal ProductBuyingPrice { get; set; }
        public int ProductPopularity { get; set; }
    }
}
