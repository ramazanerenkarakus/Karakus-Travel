using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KarakusTravel.Models.Siniflar;

namespace KarakusTravel.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(7).ToList(); //Resimlerin tamamını almak yerine 7 tanesini aldım. Değiştirilebilir.
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1() //Partial1 sondan iki blogu alıp anasayfaya eklet.
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2() //Blog ID'si 1 olan blog'u getir ve anasayfadaki 3'lü bloğa ekle
        {
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3() //En popüler 10 Kısım
        {
            var deger = c.Blogs.Take(10).ToList(); //Take(10) yapmam gerekli.Yoksa her yeni eklenen blogda yeni bir blog ekleniyor.
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList(); //en beğendiğim yerler; sol ve sağı ayırmak için kullanacağım.
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
    }
}