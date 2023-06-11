using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface ISharedServices
    {
        public int SavePicture(Picture picture);
        public decimal CalculateDiscountAmount(DateTime orderDate, decimal discountAmount);
    }
}
