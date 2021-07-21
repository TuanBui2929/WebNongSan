using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNongSan.Model;

namespace WebNongSan.Controllers
{
    public class CartController : Controller
    {
        WEBNONGSANEntities1 db = new WEBNONGSANEntities1();
        // GET: Cart
        public ActionResult Giohang()
        {
            return View((List<CartModel>)Session["cart"]);
           
        }
        public ActionResult Themgiohang(int Id,int Quantity)
        {
            if (Session["cart"] == null)
            {
                List<CartModel> cart = new List<CartModel>();
                cart.Add(new CartModel { sanpham = db.SANPHAMs.Find(Id), Quantity = Quantity });
                Session["cart"] = cart;
                Session["count"] = 1;
            }
            else
            {
                List<CartModel> cart = (List<CartModel>)Session["cart"];
                //kiểm tra sản phẩm có tồn tại trong giỏ hàng chưa???
                int index = isExist(Id);
                if (index != -1)
                {
                    //nếu sp tồn tại trong giỏ hàng thì cộng thêm số lượng
                    cart[index].Quantity += Quantity;
                }
                else
                {
                    //nếu không tồn tại thì thêm sản phẩm vào giỏ hàng
                    cart.Add(new CartModel { sanpham= db.SANPHAMs.Find(Id), Quantity = Quantity });
                    //Tính lại số sản phẩm trong giỏ hàng
                    Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                }
                Session["cart"] = cart;
            }

            ViewBag.soluong = Session["count"];
            return Json(new { Message = "Thành công",couter = Session["count"], JsonRequestBehavior.AllowGet });
        }

        private int isExist(int id)
        {
            List<CartModel> cart = (List<CartModel>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].sanpham.MA_SP.Equals(id))
                    return i;
            return -1;
        }

        //xóa sản phẩm khỏi giỏ hàng theo id
        public ActionResult Remove(int Id)
        {
            List<CartModel> li = (List<CartModel>)Session["cart"];
            li.RemoveAll(x => x.sanpham.MA_SP == Id);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return Json(new { Message = "Thành công", JsonRequestBehavior.AllowGet });
        }

        public ActionResult UpdateCart( int productid,int quantity)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            List<CartModel> cart = (List<CartModel>)Session["cart"];
            if (cart.Any(p => p.sanpham.MA_SP == productid))
            {
                cart.First(p => p.sanpham.MA_SP == productid).Quantity = quantity;              
            }
            Session["cart"] = cart;
            return Json(new { Message = "Thành công", JsonRequestBehavior.AllowGet });
        }
    }
     
    
}