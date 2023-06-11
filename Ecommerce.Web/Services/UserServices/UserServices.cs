
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.UserServices
{
    public class UserServices : IUserServices
    {
        ApplicationDbContext db;
        public UserServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public List<Gender> GetAllGenders()
        {
            return db.Genders.ToList();
        }
        public List<Religious> GetAllReligious()
        {
            return db.Religiouses.ToList();
        }

        public List<UserType> GetAllUserType()
        {
            return db.UserTypes.ToList();
        }

        public User GetUserByID(int ID)
        {
            var user = db.TblUsers.Find(ID);
            return user;
        }

        public void SaveUser(User user)
        {
            db.TblUsers.Add(user);
            db.SaveChanges();
        }

    }
}
