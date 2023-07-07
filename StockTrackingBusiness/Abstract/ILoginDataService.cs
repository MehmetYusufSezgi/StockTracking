using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Abstract
{
    public interface ILoginDataService
    {
        LoginData GetCheckState();
        LoginData GetNameByString(string checkingName);
        LoginData GetPasswordByString(string checkingName);
        void Update(LoginData loginData);
    }
}
