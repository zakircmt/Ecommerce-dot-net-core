
using Ecommerce.Services.Comment;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Ecommerce.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Comment
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ICommentServices commentService;
        public CommentController(ApplicationDbContext _db, ICommentServices _commentService)
        {
            db = _db;
            commentService = _commentService;
        }
        // GET: Comment
        public JsonResult LeaveComment(CommentViwModel model)
        {
            //var userid = id;
            //var userTypeId = 0;
            //int.TryParse(Convert.ToString(Session["SID"]), out studentid);
            //int.TryParse(Convert.ToString(Session["UserType_ID"]), out userTypeId);
            var username = HttpContext.Session.GetString("Username");
            var password = HttpContext.Session.GetString("Password");

            var user = db.TblUsers.Where(u => u.Username == username && u.Password == password && u.UserTypeID==4).FirstOrDefault();
            JsonResult result;
            if (user != null)
            {
                try
                {
                    var comment = new Ecommerce.Entities.Comment();

                    comment.Text = model.Text;
                    comment.Rating = model.Rating;
                    comment.EntityID = model.EntityID;
                    comment.RecordID = model.RecordID;
                    comment.UserID = HttpContext.Session.GetInt32("ID");
                    comment.TimeStamp = DateTime.Now;

                    var res = commentService.LeaveComment(comment);

                   result= Json(new { success = res });


                    //result.Data = new { Succes = res };
                    // result= new { Succes = res };

                }
                catch (Exception ex)
                {
                    result = Json(new { Succes = false, Message = ex.Message });
                }

            }
            else {
                result = Json(new { Succes = false, Message = "Please Login" });
            }
            
            return result;
        }
    }
}