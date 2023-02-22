using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KarakusTravel.Models.Siniflar;


namespace KarakusTravel.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context(); //GLOBAL C DEĞİŞKENİ ÜZERİNDEN İŞLEMLERİMİ GERÇEKLEŞTİRECEĞİM.
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet] //HttpGet ile bu AR sadece sayfayı geri dönecek bana.
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]//HttpPost ise bir veri gönderdiğim zaman çalışacak olan AResult. Onun için de bir parametre verdim Blog'lardan gelecek olan p parametresi
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p); //cntx'ten türettiğim c nesnesine bağlı olarak bloglara ekle. neyi p parametresinden gelen değeri. O da yazılarımdan gelecek
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id) //Blog silme işlemini id üzerinden yapacağım. önce id üzerinden bulup b'ye atadım sonra sildim.
        {
            var bs = c.Blogs.Find(id); //bs adında türettiğim nesneden devam ediyorum.
            c.Blogs.Remove(bs);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(Blog bguncel)
        {
            var blg = c.Blogs.Find(bguncel.ID); //bguncel'den gelen ID'ye göre blogu bul.
            blg.Aciklama = bguncel.Aciklama;
            blg.Baslik = bguncel.Baslik;
            blg.BlogImage = bguncel.BlogImage;
            blg.Tarih = bguncel.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index"); 
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var bs = c.Yorumlars.Find(id); 
            c.Yorumlars.Remove(bs);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi= y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;          
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}