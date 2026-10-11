using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FE1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SanPham()
        {
            return View();
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult Bonsai()
        {
            return View();
        }
        public ActionResult CayDeBan()
        {
            return View();
        }

        public ActionResult CayVanPhong()
        {
            return View();
        }

        public ActionResult CayPhongThuy()
        {
            return View();
        }

        public ActionResult ChauPhuKien()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}