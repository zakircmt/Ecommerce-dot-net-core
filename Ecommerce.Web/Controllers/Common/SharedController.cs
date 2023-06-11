

using Ecommerce.Entities;
using Ecommerce.Services.CommonServices;
using Ecommerce.Web.IServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Common
{
    public class SharedController : Controller
    {
        private readonly ISharedServices Service;
        private readonly IWebHostEnvironment _env;
        public SharedController(ISharedServices _Service, IWebHostEnvironment env)
        {
            Service = _Service;
            _env = env;
        }

        [HttpPost]
        public JsonResult UploadPictures()
        {
            JsonResult result;


            List<object> picturesJSON = new List<object>();

            var pictures = Request.Form.Files;

            for (int i = 0; i < pictures.Count; i++)
            {
                var picture = pictures[i];
                var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);

                //var path = Server.MapPath("~/Content/images/") + fileName;

               // var webRoot = webHost.WebRootPath;
                //string contentRootPath = webHost.ContentRootPath;

               // string path = "";
                var path = Path.Combine(_env.WebRootPath +"/Images");
                //or path = Path.Combine(contentRootPath , "wwwroot" ,"CSS" );
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    picture.CopyTo(stream);
                }

                //picture.SaveAs(path);
                //StreamReader reader = new StreamReader(path);
                //picture.CopyTo(reader);

                var dbPicture = new Picture();
                dbPicture.PictureURL = fileName;
                int pictureID = Service.SavePicture(dbPicture);

                picturesJSON.Add(new { ID = pictureID, pictureUrl = fileName });
            }
            result = new JsonResult( picturesJSON);

            return result;
        }

    }
}