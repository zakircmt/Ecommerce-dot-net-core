using Ecommerce.Entities;
using Ecommerce.Services.BannerServices;
using Ecommerce.Web.IServices;
using Ecommerce.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers
{
    public class BannerController : Controller
    {
        private readonly IBannerServices bannerServices;
        public BannerController(IBannerServices _bannerServices)
        {
            bannerServices = _bannerServices;
        }
        // GET: Banner
        public ActionResult Index()
        {
            var bannerlist = bannerServices.GetAllBanner();
            return View(bannerlist);
        }
        public ActionResult AddBanner()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBanner(CreateBannerModel model)
        {
            Banner banner = new Banner();

            banner.BannerName = model.BannerName;
            banner.ProductURL = model.ProductURL;
            banner.Status = model.Status;


            if (!string.IsNullOrEmpty(model.BannerPictures))
            {
                var pictureIDs = model.BannerPictures
                    .Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(ID => int.Parse(ID)).ToList();

                banner.BannerPictures = new List<BannerPicture>();
                banner.BannerPictures.AddRange(pictureIDs
                    .Select(x => new BannerPicture() { PictureID = x }).ToList());
            }
            bannerServices.SaveBanner(banner);

            return RedirectToAction("Index");
        }
        public IActionResult EditBanner(int ID)
        {
            CreateBannerModel model = new CreateBannerModel();
            Banner banner = bannerServices.GetBannerByID(ID);
            model.ID = banner.ID;
            model.BannerName = banner.BannerName;
            model.BannerPictureList = banner.BannerPictures;
            return View(model);
        }
        [HttpPost]
        public IActionResult EditBanner(CreateBannerModel model)
        {
            Banner banner = new Banner();
            banner.ID = model.ID;
            banner.BannerName = model.BannerName;
            if (!string.IsNullOrEmpty(model.BannerPictures))
            {
                var pictureIDs = model.BannerPictures
                    .Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(ID => int.Parse(ID)).ToList();

                banner.BannerPictures = new List<BannerPicture>();
                banner.BannerPictures.AddRange(pictureIDs
                    .Select(x => new BannerPicture() { PictureID = x }).ToList());
            }
            bannerServices.UpdateBanner(banner);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(Banner banner)
        {
            bannerServices.DeleteBanner(banner);
            return RedirectToAction("Index");
        }
    }
}