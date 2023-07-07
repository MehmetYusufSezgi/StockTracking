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
    public class UserManager : IUserService
    {
        private IUserDAL _userDAL;
        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void Add(User user)
        {
            _userDAL.Add(user);
        }

        public void Delete(User user)
        {
            _userDAL.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDAL.GetAll();
        }

        public User GetUserByName(string existingUser)
        {
            return _userDAL.Get(p => p.UserName.Equals(existingUser));
        }

        public List<User> GetUsersByName(string userName)
        {
            return _userDAL.GetAll(p => p.UserName.ToLower().Contains(userName.ToLower()));
        }

        public void Update(User user)
        {
            _userDAL.Update(user);
        }
    }
}
