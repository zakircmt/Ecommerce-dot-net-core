using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface IUserServices
    {
        public List<Gender> GetAllGenders();
        public List<Religious> GetAllReligious();
        public List<UserType> GetAllUserType();
        public User GetUserByID(int ID);
        public void SaveUser(User user);
    }
}
