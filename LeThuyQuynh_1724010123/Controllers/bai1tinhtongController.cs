using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThuyQuynh_1724010123.Controllers
{
    public class bai1tinhtongController : Controller
    {
        // GET: bai1tinhtong
        public ActionResult TinhtongS(string NhapN)
        {
            double n;
            double s = 0;
            n = Convert.ToDouble(NhapN);
            for(int i=1;i<n;i++)
            {
                s = s + (double)1 / i;
            }
            ViewBag.tinhtong = "Tổng S là:" + s;
            return View();
        }
    }
}