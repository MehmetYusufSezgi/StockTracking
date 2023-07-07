using StockTracking;
using StockTrackingBusiness.Abstract;
using StockTrackingBusiness.Concrete;
using StockTrackingDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTrackingEntities.Concrete;

namespace StockTrackingBusiness
{
    public class ExceptionHandler
    {
        IDBExceptionService _exceptionService;
        
        public ExceptionHandler()
        {
            _exceptionService = new DBExceptionManager(new EFDBExceptionDAL());
        }
        public void TryCatcher(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch(Exception ex)
            {
                _exceptionService.Add(new DBException
                {
                    DBExceptionUser = StaticCarrier.LoggedName,
                    DBExceptionMessage = ex.Message,
                });
                MessageBox.Show("Bir hata meydana geldi. Veri tabanına kaydedildi.");
            }
        }
    }
}
