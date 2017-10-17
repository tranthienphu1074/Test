using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class AddItemsController : Controller
    {
        DefaultConnectionEntities db = new DefaultConnectionEntities();
        #region[Create]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, DanhMuc danhMuc)
        {
            string TenSanPhams = collection["txtTenSanPham"];
            float GiaTiens = float.Parse(collection["txtGiaTien"]);
            string Hangs = collection["txtHang"];
            string Images = collection["txtAnh"];
            string Descriptions = collection["txtThongTin"];

            danhMuc.TenSanPham = TenSanPhams;
            danhMuc.GiaTien = GiaTiens;
            danhMuc.Hang = Hangs;
            danhMuc.Image = Images;
            danhMuc.Description = Descriptions;

            db.DanhMucs.Add(danhMuc);
            db.SaveChanges();
            return RedirectToAction(actionName: "Default", controllerName: "Default");
        }
        #endregion
    }
}