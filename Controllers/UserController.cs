using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNongSan.Model;


namespace WebNongSan.Controllers
{
    public class UserController : Controller
    {
        WEBNONGSANEntities1 db = new WEBNONGSANEntities1();
        // GET: User
       
        public ActionResult DangNhap()
        {
            return View();
        }
        public ActionResult DangXuat()
        {
            Session.Abandon();
            return RedirectToAction("DangNhap");
           // return View();
        }
        [HttpPost]
        public ActionResult DangNhap(TAIKHOAN user)
        {
            var check = db.TAIKHOANs.FirstOrDefault(m => m.EMAIL.Equals(user.EMAIL) && m.MK.Equals(user.MK));
            if (check == null)
            {
                user.DangNhapThatBai = "Nhap Sai Mat Khau Hoac Email";
                return View("DangNhap", user);

            }
            else
            {
                Session["iUser"] = " Đăng Xuất";
                Session["Ten"] = check.TENKH;
                return RedirectToAction("home", "home");
            }

            return View();
        }

        [HttpGet]
        public ActionResult DangKi()
        {
            return View();
        }


       [HttpPost]
        public ActionResult DangKi(TAIKHOAN user)
        {
            if (ModelState.IsValid)
            {
                var check = db.TAIKHOANs.FirstOrDefault(s => s.EMAIL == user.EMAIL);
                if (check == null)
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.TAIKHOANs.Add(user);
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