using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KarakusTravel.Models.Siniflar;

namespace KarakusTravel.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog,
        Context c = new Context();
        BlogYorum by = new BlogYorum(); //Blog yorum sınıfından bir nesne türettim 

        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(5).ToList(); //Sondan başa doğru descending olarak ID değerine göre çağırmak için. Son 3 blog gelecek.
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blogBul = c.Blogs.Where(x => x.ID== id).ToList(); //x öyle ki benim gönderdiğim id parametresi ile eşleşiyorsa veritabanından ID olanı bul ve onu döndür
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id) //id'yi yorum yap kısmında el ile girmemek için düzenlediğim kısım
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}