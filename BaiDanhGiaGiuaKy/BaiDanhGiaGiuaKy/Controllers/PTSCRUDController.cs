using BaiDanhGiaGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BaiDanhGiaGiuaKy.Controllers
{
    public class PTSCRUDController : Controller
    {
        private static List<PTSProduct> ptsProducts = new List<PTSProduct>
        {
            new PTSProduct (){PTSID=0,PTSName="Phạm tùng sơn",PTSImage="12345543523fdsgfda", PTSQuanlity=60,PTSPrice=1000,PTSIssActive=true},
            new PTSProduct (){PTSID=1,PTSName="Sơn phạm tùng",PTSImage="123534245543523fdsgfda", PTSQuanlity=70,PTSPrice=2000,PTSIssActive=true}
        };


        // GET: PTSCRUD
        public ActionResult PTSIndex()
        {
            return View(ptsProducts);
        }

        public ActionResult PTSCreate()
        {
            var ptsModel = new PTSProduct();
            return View(ptsModel);
        }
        public ActionResult PTSEdit(int id)
        {
            var product = ptsProducts.Find(p => p.PTSID == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult DthCreate(PTSProduct ptsProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(ptsProduct);
            }
            ptsProducts.Add(ptsProduct);
            return RedirectToAction("PTSIndex");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DthEdit(PTSProduct ptsProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(ptsProduct);
            }

            var product = ptsProducts.Find(p => p.PTSID == ptsProduct.PTSID);
            if (product == null)
            {
                return HttpNotFound();
            }

            // Cập nhật các giá trị
            product.PTSName = ptsProduct.PTSName;
            product.PTSImage = ptsProduct.PTSImage;
            product.PTSQuanlity = ptsProduct.PTSQuanlity;
            product.PTSPrice = ptsProduct.PTSPrice;

            return RedirectToAction("DthIndex");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PTSDelete(int id)
        {
            var product = ptsProducts.FirstOrDefault(p => p.PTSID == id);
            if (product == null)
            {
                return HttpNotFound();
            }

            ptsProducts.Remove(product);

            return RedirectToAction("PTSIndex");
        }


    }
}