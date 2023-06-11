
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Checkout
{
    public class CheckoutServices : ICheckoutServices
    {
        ApplicationDbContext db;
        public CheckoutServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public List<Product> GetProductsForCheckout(List<int> IDs)
        {
                return db.Products.Where(product => IDs.Contains(product.ID)).ToList();
        }
        public int SaveOrder(Ecommerce.Entities.Order order)
        {
            db.Orders.Add(order);
            return db.SaveChanges();
        }
    }
}
