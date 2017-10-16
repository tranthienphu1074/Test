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
            var product = (from p in db.DanhMucs orderby p.ID descending select p).Take(12).ToList();
            for(int i = 0; i < product.Count; i++)
            {
            }
            ViewBag.View = Chuoi;
            return View();
        }
    }
}