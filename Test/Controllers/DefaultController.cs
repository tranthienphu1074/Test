using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class DefaultController : Controller
    {
        DefaultConnectionEntities db = new DefaultConnectionEntities();
        public ActionResult Default()
        {
            string Chuoi = "";
            var product = (from p in db.DanhMucs orderby p.ID ascending select p).Take(12).ToList();
            for(int i = 0; i < product.Count; i++)
            {
                 Chuoi += "<div class=\"item-pro-home\">";
                 Chuoi += "<div class=\"box-img-pro-home\">";
                 Chuoi += "<img src = \"" + product[i].Image + "\" />";
                 Chuoi += "</div>";
                 Chuoi += "<a href=\"#\">"+ product[i].TenSanPham +"</a>";
                 Chuoi += "<p>Giá: "+ product[i].Giatien +"</p>";
                 Chuoi += "</div>";
            }
            ViewBag.View = Chuoi;
            return View();
        }
    }
}