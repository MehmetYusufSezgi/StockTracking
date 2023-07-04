using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingDataAccess.Abstract
{
    public interface ICategoryDAL:IEntityRepository<Category>
    {
    }
}
