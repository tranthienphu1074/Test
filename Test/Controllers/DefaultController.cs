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
            var product = (from p in db.DanhMucs orderby p.ID ascending select p).Take(100).ToList();
            for(int i = 0; i < product.Count; i++)
            {
                 Chuoi += "<div class=\"item-pro-home\">";
                 Chuoi += "<div class=\"box-img-pro-home\">";
                 Chuoi += "<img src = \"" + product[i].Image + "\" />";
                 Chuoi += "</div>";
                 Chuoi += "<a href=\"#\">"+ product[i].TenSanPham +"</a>";
                 Chuoi += "<p>Giá: "+ product[i].GiaTien +"</p>";
                 Chuoi += "</div>";
            }
            ViewBag.View = Chuoi;
            return View(product);
        }

        public ActionResult ACER()
        {
            string Chuoi = "";
            var product = (from p in db.DanhMucs where p.Hang == "ACER"  select p).Take(100).ToList();
            for (int i = 0; i < product.Count; i++)
            {
                Chuoi += "<div class=\"item-pro-home\">";
                Chuoi += "<div class=\"box-img-pro-home\">";
                Chuoi += "<img src = \"" + product[i].Image + "\" />";
                Chuoi += "</div>";
                Chuoi += "<a href=\"#\">" + product[i].TenSanPham + "</a>";
                Chuoi += "<p>Giá: " + product[i].GiaTien + "</p>";
                Chuoi += "</div>";
            }
            ViewBag.ACER = Chuoi;
            return View(product);
        }

        public ActionResult ASUS()
        {
            string Chuoi = "";
            var product = (from p in db.DanhMucs where p.Hang == "ASUS" select p).Take(100).ToList();
            for (int i = 0; i < product.Count; i++)
            {
                Chuoi += "<div class=\"item-pro-home\">";
                Chuoi += "<div class=\"box-img-pro-home\">";
                Chuoi += "<img src = \"" + product[i].Image + "\" />";
                Chuoi += "</div>";
                Chuoi += "<a href=\"#\">" + product[i].TenSanPham + "</a>";
                Chuoi += "<p>Giá: " + product[i].GiaTien + "</p>";
                Chuoi += "</div>";
            }
            ViewBag.ASUS = Chuoi;
            return View(product);
        }

        public ActionResult DELL()
        {
            string Chuoi = "";
            var product = (from p in db.DanhMucs where p.Hang == "DELL" select p).Take(100).ToList();
            for (int i = 0; i < product.Count; i++)
            {
                Chuoi += "<div class=\"item-pro-home\">";
                Chuoi += "<div class=\"box-img-pro-home\">";
                Chuoi += "<img src = \"" + product[i].Image + "\" />";
                Chuoi += "</div>";
                Chuoi += "<a href=\"#\">" + product[i].TenSanPham + "</a>";
                Chuoi += "<p>Giá: " + product[i].GiaTien + "</p>";
                Chuoi += "</div>";
            }
            ViewBag.DELL = Chuoi;
            return View(product);
        }

        public ActionResult MAC()
        {
            string Chuoi = "";
            var product = (from p in db.DanhMucs where p.Hang == "MAC" select p).Take(100).ToList();
            for (int i = 0; i < product.Count; i++)
            {
                Chuoi += "<div class=\"item-pro-home\">";
                Chuoi += "<div class=\"box-img-pro-home\">";
                Chuoi += "<img src = \"" + product[i].Image + "\" />";
                Chuoi += "</div>";
                Chuoi += "<a href=\"#\">" + product[i].TenSanPham + "</a>";
                Chuoi += "<p>Giá: " + product[i].GiaTien + "</p>";
                Chuoi += "</div>";
            }
            ViewBag.MAC = Chuoi;
            return View(product);
        }
    }
}