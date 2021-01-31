using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThuyQuynh_1724010123.Controllers
{
    public class bai3SonguyentoController : Controller
    {
        // GET: bai3Songuyento
        public ActionResult SoNguyenTo(string SoN)
        {
            int n, tong = 0;
            n = Convert.ToInt32(SoN);
            List<int> SoNguyenTo = new List<int>(); 
          
            {
                ViewBag.ketqua = "Không có số nguyên tố nào < " + n;
            }
            for (int i = 1; i < n; i++)
            {
                if (kiemtrasonguyento(i))
                {
                    SoNguyenTo.Add(i);
                }
            }
            foreach (int a in SoNguyenTo) 
            {
                int check = tong + a;
                if (check < 100)
                {
                    tong += a;
                }
            }
            bool kiemtrasonguyento(int number)
            {
                int dem = 0;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            ViewBag.List = "Các số nguyên tố < " + n + " " + SoNguyenTo;
            ViewBag.Tong = "Tổng các số nguyên tố = " + tong;
            return View();
        }
    }
}
