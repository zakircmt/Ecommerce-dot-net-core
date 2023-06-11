
using Ecommerce.Entities;
using Ecommerce.Service;
using Ecommerce.Services.BrandService;
using Ecommerce.Services.Comment;
using Ecommerce.Services.Order;
using Ecommerce.Services.UserServices;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Ecommerce.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.User
{
    public class UserDashboardController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ICommentServices commentServices;
        private readonly ICategoryServices categoryServices;
        private readonly IBrandServices brandServices;
        private readonly IUserServices userServices;
        private readonly IProductServices productServices;
        private readonly IOrderServices orderServices;
        public UserDashboardController(ApplicationDbContext _db, ICommentServices _commentServices, ICategoryServices _categoryServices,
            IBrandServices _brandServices, IUserServices _userServices, IProductServices _productServices, IOrderServices _orderServices)
        {
            db = _db;
            commentServices = _commentServices;
            categoryServices = _categoryServices;
            brandServices = _brandServices;
            userServices = _userServices;
            productServices = _productServices;
            orderServices = _orderServices;
        }
        // GET: UserDashboard
        public ActionResult Index(int ID)
        {
            var id = ID;

            LayoutViewModel model = new LayoutViewModel();
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;
            model.Branding = brandServices.GetAllBrand();
            return View(model);
        }
        public ActionResult commentsList(int ID)
        {
            var username = HttpContext.Session.GetString("Username");
            var password = HttpContext.Session.GetString("Password");
            var user = db.TblUsers.Where(u => u.Username == username && u.Password == password && u.UserTypeID == 4).FirstOrDefault();

            if (user==null)
            {
                return RedirectToAction("Login", "Auth");
            }
            else {
                var category = categoryServices.GetNineCategory();
                ViewBag.NineCategory = category;
                CommentListViwModel model = new CommentListViwModel();
                model.Branding = brandServices.GetAllBrand();
                //model.Comments = commentServices.GetAllCommentByUserID(ID);
                model.User = userServices.GetUserByID(ID);
                    if (model.User != null)
                    {
                        model.Comments = commentServices.GetCommentsByUser(ID, (int)EntityEnums.Product);

                        if (model.Comments != null && model.Comments.Count > 0)
                        {
                            var productIDs = model.Comments.Select(x => x.RecordID).ToList();

                            model.Products = productServices.GetProductByIDs(productIDs);
                        }
                        //model.userRoles = model.User.Roles.Select(userRole => model.AvailableRoles.FirstOrDefault(role => role.Id == userRole.RoleId)).ToList();
                    }
                return View(model);
            }
        }
        public ActionResult MyOrderList(int ID)
        {
            var username = HttpContext.Session.GetString("Username");
            var password = HttpContext.Session.GetString("Password");
            var user = db.TblUsers.Where(u => u.Username == username && u.Password == password && u.UserTypeID == 4).FirstOrDefault();

            if (user == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            else {
                UserOrderViewModel model = new UserOrderViewModel();
                var category = categoryServices.GetNineCategory();
                ViewBag.NineCategory = category;
                model.Branding = brandServices.GetAllBrand();
                
                model.Orders = orderServices.GetAllOrderByUser(ID);


                return View(model);
            }
            
        }
    }
}