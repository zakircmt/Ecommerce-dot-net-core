
using Ecommerce.Entities;
using Ecommerce.Service;
using Ecommerce.Services.BrandService;
using Ecommerce.Services.Checkout;
using Ecommerce.Services.CommonServices;
using Ecommerce.Services.ManufactureServices;
using Ecommerce.Services.Order;
using Ecommerce.Services.Size;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Ecommerce.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Shop
{
    public class ShopController : Controller
    {
        private readonly ICheckoutServices checkoutServices;
        private readonly ICategoryServices categoryServices;
        private readonly IProductServices productServices;
        private readonly IBrandServices brandServices;
        private readonly IManufacturerServices manufacturerServices;
        private readonly ISizeServices sizeServices;
        private readonly ApplicationDbContext db;
        private readonly IOrderServices orderServices;
        private readonly ISharedServices sharedServices;
        public ShopController(ICheckoutServices _checkoutServices, ICategoryServices _categoryServices,
             IProductServices _productServices, IBrandServices _brandServices, IManufacturerServices _manufacturerServices,
             ISizeServices _sizeServices, ApplicationDbContext _db, IOrderServices _orderServices,
             ISharedServices _sharedServices)
        {
            checkoutServices = _checkoutServices;
            categoryServices = _categoryServices;
            productServices = _productServices;
            brandServices = _brandServices;
            manufacturerServices = _manufacturerServices;
            sizeServices = _sizeServices;
            db = _db;
            orderServices = _orderServices;
            sharedServices = _sharedServices;
        }

        // GET: Shop
        public ActionResult Index(string searchTerm, int? manufactureID, int? minimum, int? maximum)
        {
            ShopViewModel model = new ShopViewModel();
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;

            model.Products = productServices.GetAllProduct();
            model.Branding = brandServices.GetAllBrand();
            model.Manufacturers = manufacturerServices.GetSixManufacture();
            model.ProductSizes = sizeServices.GetAllProductSize().Take(4).ToList();

            model.Minimum = productServices.GetMinimumPrice();
            model.Maximum = productServices.GetMaximumPrice();

            model.Products = productServices.SearchProduct(searchTerm,manufactureID,minimum,maximum);

            return View(model);
        }

        public ActionResult FilterBySlideProduct(string searchTerm, int? manufactureID, int? minimum, int? maximum)
        {
            FilterProductViewModel model = new FilterProductViewModel();
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;

            model.Products = productServices.GetAllProduct();
            model.Branding = brandServices.GetAllBrand();

            //model.Minimum = productServices.GetMinimumPrice();
            //model.Maximum = productServices.GetMaximumPrice();

            model.Products = productServices.SearchProduct(searchTerm, manufactureID, minimum, maximum);

            return PartialView(model);
        }

        public ActionResult MyCart()
        {
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;
            
            CartViewModel model = new CartViewModel();
            model.Branding = brandServices.GetAllBrand();
            var CartProductsCookie = Request.Cookies["CartProducts"];
            if (CartProductsCookie != null && !string.IsNullOrEmpty(CartProductsCookie))
            {
                // var productIDs = CartProductsCookie.Value;
                // var IDs = productIDs.Split('-');
                // List<int> pIDs = IDs.Select(productID => int.Parse(productID)).ToList();

                model.CartProductIDs = CartProductsCookie.Split('-').Select(x => int.Parse(x)).ToList();

                model.CartProducts = checkoutServices.GetProductsForCheckout(model.CartProductIDs);


                // model.User = UserManager.FindById(User.Identity.GetUserId());
            }
            return View(model);
        }
        public JsonResult PlaceOrder(string productIDs)
        {
            var username = HttpContext.Session.GetString("Username");
            var password = HttpContext.Session.GetString("Password");

            var checkUser = db.TblUsers.Where(x => x.Username == username && x.Password == password && x.UserTypeID == 4).FirstOrDefault();
            JsonResult result;
            if (checkUser!=null)
            {
                if (!string.IsNullOrEmpty(productIDs))
                {
                    var productQuantities = productIDs.Split('-').Select(x => int.Parse(x)).ToList();
                    var productIds = productIDs.Split(new char[] { '-' }).Select(x => int.Parse(x)).Distinct().ToList();
                    var buyProducts = productServices.GetProduct(productIds);

                    Ecommerce.Entities.Order newOrder = new Ecommerce.Entities.Order();

                    newOrder.UserID = Convert.ToInt32(HttpContext.Session.GetInt32("ID"));
                    newOrder.OrdereDate = DateTime.Now;
                    newOrder.Status = "Pending";
                    newOrder.TotalAmount = buyProducts.Sum(x => x.ProductSalePrice * productQuantities.Where(productID => productID == x.ID).Count());
                    newOrder.DiscountPercen = 10;
                    newOrder.DiscoutBalanace = (newOrder.TotalAmount * newOrder.DiscountPercen) / 100;
                    var payable = (newOrder.TotalAmount - newOrder.DiscoutBalanace);
                    newOrder.PayableBalance = payable + 70;
                    var dividedPayableBalance = newOrder.DiscoutBalanace / 90;

                    newOrder.OrderItems = new List<OrderItem>();
                    newOrder.OrderItems.AddRange(buyProducts.Select(x => new OrderItem()
                    {
                        ProductID = x.ID,
                        UserID = Convert.ToInt32(HttpContext.Session.GetInt32("ID")),
                        Quantity = productQuantities.Where(productID => productID == x.ID).Count()
                    }));

                    var rowsAffected = checkoutServices.SaveOrder(newOrder);

                    result = Json( new { Success = true, Rows = rowsAffected });
                }
                else
                {
                    result = Json(new { Success = false });
                }
            }
            else
            {
                result = Json(new { Success = false });
            }
            return result;
        }
        public ActionResult OrderDetail(int ID)
        {
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;
            UserOrderViewModel model = new UserOrderViewModel();
            model.Branding = brandServices.GetAllBrand();
            model.Order = db.Orders.Find(ID);
            var userID = Convert.ToInt32(HttpContext.Session.GetInt32("ID"));

            if (model.Order!=null)
            {
                model.OrderItems = orderServices.GetAllOrderItemByOrderID(ID, userID);
            }
            decimal currentDiscount = 0;
            var user = db.TblUsers.Find(5);
            foreach(var order in user.Orders)
            {
                currentDiscount += sharedServices.CalculateDiscountAmount(order.OrdereDate.Value, order.DiscoutBalanace);
            }
           



            //var user = userServices.GetUserByID(ID);
            //model.User = userServices.GetUserByID(ID);
            //if (model.User!=null)
            //{
            //    model.Orders = orderServices.GetAllOrderDetailByOrderID(ID);
            //    if (model.Orders != null && model.Orders.Count > 0)
            //    {
            //      var  orderItemIDs = model.OrderItems.Select(x => x.ID).ToList();
            //    }
            //}
            return View(model);
        }
    }
}