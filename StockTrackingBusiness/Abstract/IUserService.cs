using StockTrackingEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingBusiness.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        List<User> GetAll();
        User GetUserByName(string existingUser);
        List<User> GetUsersByName(string userName);
        void Update(User user);
    }
}
