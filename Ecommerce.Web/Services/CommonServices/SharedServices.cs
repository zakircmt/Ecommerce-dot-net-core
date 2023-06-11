
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.CommonServices
{
    public class SharedServices : ISharedServices
    {
        ApplicationDbContext db;
        public SharedServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public int SavePicture(Picture picture)
        {
            db.Pictures.Add(picture);
            db.SaveChanges();
            return picture.ID;
        }
        public decimal CalculateDiscountAmount(DateTime orderDate, decimal discountAmount)
        {

            var perDayDiscount = (discountAmount / 90);
            var dayCount =(decimal) (DateTime.Now.Date - orderDate.Date).TotalDays;
            var currentBalance = perDayDiscount * dayCount;
            return currentBalance;
         }
    }
}
