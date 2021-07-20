using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebNongSan.Model
{
    public class CartModel
    {
        public SANPHAM sanpham { get; set; }
        public int Quantity { get; set; }
    }
}