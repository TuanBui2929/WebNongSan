using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNongSan.Model;

namespace WebNongSan.Controllers
{
    public class HomeController : Controller
    {
        WEBNONGSANEntities1 db = new WEBNONGSANEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult home()
        {
            var sanpham = db.SANPHAMs.ToList();
            return View(sanpham);
        }
        public ActionResult detail(int id)
        {
            SANPHAM sp = db.SANPHAMs.FirstOrDefault(n => n.MA_SP == id); 
            return View(sp);
        }


    }
}