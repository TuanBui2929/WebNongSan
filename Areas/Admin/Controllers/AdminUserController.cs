using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNongSan.Model;

namespace WebNongSan.Areas.Admin.Controllers
{
    public class AdminUserController : Controller
    {
        WEBNONGSAN1Entities db = new WEBNONGSAN1Entities();
        // GET: User

        public ActionResult DangNhap()
        {
          
            return View();
        }
      
        public ActionResult DangXuat()
        {
            Session.Abandon();
            return RedirectToAction("home", "Home", new { Area = "" });
            // return View();
        }
        [HttpPost]
        public ActionResult DangNhap(TKAdmin user)
        {
            var check = db.TKAdmins.FirstOrDefault(m => m.EMAIL.Equals(user.EMAIL) && m.MK.Equals(user.MK));
            if (check == null)
            {
                user.DangNhapThatBai = "Nhap Sai Mat Khau Hoac Email";
                return View("DangNhap", user);
            }
            else
            {
                Session["iUser"] = "Đăng Xuất";
                Session["Ten"] = check.TENadmin;
                return RedirectToAction("Index","AdminSANPHAMs");
            }

        }

        [HttpGet]
        public ActionResult DangKi()
        {
            return View();
        }


        [HttpPost]
        public ActionResult DangKi(TKAdmin user)
        {
            if (ModelState.IsValid)
            {
                var check = db.TKAdmins.FirstOrDefault(s => s.EMAIL == user.EMAIL);
                if (check == null)
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.TKAdmins.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("DangNhap");
                }
                else
                {
                    ViewBag.error = "Email đã tồi tại";
                    return View();
                }
            }
            return View();


        }
     

    }
}