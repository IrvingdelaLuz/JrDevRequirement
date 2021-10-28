using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JrDevRequirement.Models;
using System.Diagnostics;
using JrDevRequirement.Services;

namespace JrDevRequirement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Image()
        {
            //TableService service = new TableService();
            List<Images> list = TableService.getImageList();
            ViewBag.List = list;
            return View();
        }

        [HttpPost]
        public ActionResult Image(imageConvert img)
        {
            try
            {
                //ImageService service = new ImageService();
                ImageService.imageSave(img);
            }catch (DbEntityValidationException ex)
            {
                Debug.WriteLine("ERROR: " + ex.ToString() + ex.Message);
                Response.StatusCode = 400;
            }
            return Json(Url.Action("Image", "Home"));
        }

    }
}