using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface ICommentServices
    {
        public bool LeaveComment(Ecommerce.Entities.Comment comment);
        public List<Ecommerce.Entities.Comment> GetComments(int enitiyID, int recordID);
        public List<Ecommerce.Entities.Comment> GetAllCommentByUserID(int ID);
        public List<Ecommerce.Entities.Comment> GetCommentsByUser(int userID, int entityID);
    }
}
