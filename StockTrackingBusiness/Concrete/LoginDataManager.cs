using StockTrackingBusiness.Abstract;
using StockTrackingDataAccess.Abstract;
using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Concrete
{
    public class LoginDataManager : ILoginDataService
    {
        private ILoginDataDAL _loginDataDAL;
        public LoginDataManager(ILoginDataDAL loginDataDAL)
        {
            _loginDataDAL = loginDataDAL;
        }

        public LoginData GetCheckState()
        {
            return _loginDataDAL.Get(p => p.IsCheckedLOGIN);
        }

        public LoginData GetNameByString(string checkingName)
        {
            return _loginDataDAL.Get(p => p.CurrentNameLOGIN.Contains(checkingName));
        }

        public LoginData GetPasswordByString(string checkingName)
        {
            return _loginDataDAL.Get(p => p.CurrentPasswordLOGIN.Contains(checkingName));
        }

        public void Update(LoginData loginData)
        {
            _loginDataDAL.Update(loginData);
        }
    }
}
