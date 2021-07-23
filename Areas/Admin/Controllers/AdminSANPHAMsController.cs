using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebNongSan.Model;

namespace WebNongSan.Areas.Admin.Controllers
{
    
    public class AdminSANPHAMsController : Controller
    {
        private WEBNONGSAN1Entities db = new WEBNONGSAN1Entities();

        // GET: Admin/AdminSANPHAMs
        public ActionResult Index()
        {

            
            if (Session["iUser"] == null)
            {
                return RedirectToAction("DangNhap", "AdminUser");
            }
            else
            {
                var sANPHAMs = db.SANPHAMs.Include(s => s.DANHMUCSANPHAM);
                return View(sANPHAMs.ToList());
            }


        }

        // GET: Admin/AdminSANPHAMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // GET: Admin/AdminSANPHAMs/Create
        public ActionResult Create()
        {
            ViewBag.MALOAISP = new SelectList(db.DANHMUCSANPHAMs, "MALOAISP", "TENDANHMUC");
            return View();
        }

        // POST: Admin/AdminSANPHAMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.SANPHAMs.Add(sANPHAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MALOAISP = new SelectList(db.DANHMUCSANPHAMs, "MALOAISP", "TENDANHMUC", sANPHAM.MALOAISP);
            return View(sANPHAM);
        }

        // GET: Admin/AdminSANPHAMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            ViewBag.MALOAISP = new SelectList(db.DANHMUCSANPHAMs, "MALOAISP", "TENDANHMUC", sANPHAM.MALOAISP);
            return View(sANPHAM);
        }

        // POST: Admin/AdminSANPHAMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MA_SP,TEN_SP,GIABAN,GIAGOC,VANCHUYEN,THONGTINSP,THUONGHIEU,GIAMGIA,SOLUONG,IMAGES,MALOAISP")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sANPHAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MALOAISP = new SelectList(db.DANHMUCSANPHAMs, "MALOAISP", "TENDANHMUC", sANPHAM.MALOAISP);
            return View(sANPHAM);
        }

        // GET: Admin/AdminSANPHAMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // POST: Admin/AdminSANPHAMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            db.SANPHAMs.Remove(sANPHAM);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
