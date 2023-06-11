using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface IOrderServices
    {
        public List<Ecommerce.Entities.Order> GetAllOrderByUser(int ID);
        public List<OrderItem> GetAllOrderItemByOrderID(int ID, int UserID);
    }
}
