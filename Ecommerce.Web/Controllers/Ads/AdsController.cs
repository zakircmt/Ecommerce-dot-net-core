using Ecommerce.Entities;
using Ecommerce.Services.Ads;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Ecommerce.Web.Models.Ads;
using Ecommerce.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Ads
{
    public class AdsController : Controller
    {
        private readonly IAdsServices adsServices;
        private readonly ApplicationDbContext db;
        public AdsController(IAdsServices _adsServices,ApplicationDbContext _db)
        {
            adsServices = _adsServices;
            db = _db;
        }
        // GET: Ads
        public ActionResult Index()
        {
            var sbannerList = adsServices.GetAllSecoundBanner();

            return View(sbannerList);
        }
        public ActionResult AddAds()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAds(CreateAdsModel model)
        {
            SecoundBanner  secoundBanner = new SecoundBanner();

            secoundBanner.SBannerName = model.SBannerName;
            secoundBanner.Description = model.Description;
            secoundBanner.Status = model.Status;


            if (!string.IsNullOrEmpty(model.SecoundBannerPictures))
            {
                var pictureIDs = model.SecoundBannerPictures
                    .Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(ID => int.Parse(ID)).ToList();

                secoundBanner.SecoundBannerPictures = new List<SecoundBannerPicture>();
                secoundBanner.SecoundBannerPictures.AddRange(pictureIDs
                    .Select(x => new SecoundBannerPicture() { PictureID = x }).ToList());
            }
            adsServices.SaveSecoundBanner(secoundBanner);

            return RedirectToAction("Index");
        }
        public IActionResult EditAds(int ID)
        {
            CreateAdsModel model = new CreateAdsModel();
            SecoundBanner secoundBanner = adsServices.GetAdsByID(ID);
            model.ID = secoundBanner.ID;
            model.SBannerName = secoundBanner.SBannerName;
            model.Description = secoundBanner.Description;

            model.SecoundBannerPictureList = secoundBanner.SecoundBannerPictures;

            return View(model);
        }
        [HttpPost]
        public IActionResult EditAds(CreateAdsModel model)
        {
            SecoundBanner secoundBanner = new SecoundBanner();
            secoundBanner.ID = model.ID;
            secoundBanner.SBannerName = model.SBannerName;
            secoundBanner.Description = model.Description;

            if (!string.IsNullOrEmpty(model.SecoundBannerPictures))
            {
                var pictureIDs = model.SecoundBannerPictures
                    .Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(ID => int.Parse(ID)).ToList();

                secoundBanner.SecoundBannerPictures = new List<SecoundBannerPicture>();
                secoundBanner.SecoundBannerPictures.AddRange(pictureIDs
                    .Select(x => new SecoundBannerPicture() { SecoundBannerID = secoundBanner.ID, PictureID = x }).ToList());
            }
            adsServices.UpdateAds(secoundBanner);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteAds(int ID)
        {
            var findAds = adsServices.GetAdsByID(ID);
            adsServices.DeleteAds(findAds);
            return RedirectToAction("Index");
        }
    }
}