using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThuyQuynh_1724010123.Controllers
{
    public class bai2GPTbac2Controller : Controller
    {
        // GET: bai2GPTbac2
        public ActionResult GiaiPTbac2(string HsA,string HsB,string HsC)
        {
            double a, b, c, delta, x1 = 0, x2 = 0;
            string ketqua = "";
            a = Convert.ToDouble(HsA);
            b = Convert.ToDouble(HsB);
            c = Convert.ToDouble(HsC);
            delta = b * b - 4 * a * c;
            if(a==0)
            {
                x1 = -c / b;
                ketqua = "Phương trình có nghiệm x1=" + x1;
            }
            else
            {
                if(delta<0)
                {
                    ketqua = "Phương trình vô nghiệm";
                }    
                else if(delta==0)
                {
                    x1 = -b / 2 * a;
                    ketqua = "Phương trình có nghiệm kép x1=" + x1;
                }  
                else if(delta>0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    ketqua = "Phương trình có nghiệm x2=" + x2;
                }    
            }
            ViewBag.Thongbao = ketqua;
            return View();
        }
    }
}