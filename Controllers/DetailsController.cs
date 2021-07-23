using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNongSan.Model;

namespace WebNongSan.Controllers
{
    public class DetailsController : Controller
    {
        WEBNONGSAN1Entities db = new WEBNONGSAN1Entities();
        // GET: Details
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Traicay(int? page)
        {
            var sanpham = db.SANPHAMs.Where(m => m.DANHMUCSANPHAM.TENDANHMUC.Equals("RAU_CU_TRAICAY")).ToList();
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            sanpham = sanpham.OrderByDescending(n => n.MALOAISP).ToList();

            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult Haisan(int? page)
        {
            var sanpham = db.SANPHAMs.Where(m => m.DANHMUCSANPHAM.TENDANHMUC.Equals("THIT_HAISAN_TRUNG")).ToList();
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            sanpham = sanpham.OrderByDescending(n => n.MALOAISP).ToList();

            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult Sua(int? page)
        {
            var sanpham = db.SANPHAMs.Where(m => m.DANHMUCSANPHAM.TENDANHMUC.Equals("SUA_SANPHAMTUSUA")).ToList();
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            sanpham = sanpham.OrderByDescending(n => n.MALOAISP).ToList();

            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult Douong(int? page)
        {
            var sanpham = db.SANPHAMs.Where(m => m.DANHMUCSANPHAM.TENDANHMUC.Equals("DOUONG_NUOCEP")).ToList();
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            sanpham = sanpham.OrderByDescending(n => n.MALOAISP).ToList();

            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult Banhkeo(int? page)
        {
            var sanpham = db.SANPHAMs.Where(m => m.DANHMUCSANPHAM.TENDANHMUC.Equals("BANHKEO_DACSAN")).ToList();
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            sanpham = sanpham.OrderByDescending(n => n.MALOAISP).ToList();

            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }

        public ActionResult search(string currentFilter,string SearchString,int? page)
        {

            //var sanpham = db.SANPHAMs.Where(n=>n.TEN_SP.Contains(SearchString)).ToList();
            var sanpham = new List<SANPHAM>();
            if (SearchString != null)
            {
                page = 1;
            }
            else
            {
                SearchString = currentFilter;
            }
            if (!string.IsNullOrEmpty(SearchString))
            {
                 sanpham = db.SANPHAMs.Where(n => n.TEN_SP.ToLower().Contains(SearchString.ToLower())||n.DANHMUCSANPHAM.TENDANHMUC.ToLower().Contains(SearchString.ToLower())).ToList();

            }
            else
            {
                sanpham = db.SANPHAMs.ToList();
            }
            ViewBag.CurrentFilter = SearchString;
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            sanpham = sanpham.OrderByDescending(n => n.MALOAISP).ToList();

            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
    }
}