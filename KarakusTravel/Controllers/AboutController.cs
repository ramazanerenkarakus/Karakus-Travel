using KarakusTravel.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KarakusTravel.Models.Siniflar; // Bunu eklemeyi unutmamak gerek.

namespace KarakusTravel.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context(); // Context'ten sınıflarıma erişebilmem için bir nesne tüertmem gerekli.  
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList(); // Ardından c nesnesinden hakkımızdas'a erişip oradaki verileri listeleteceğim.
            return View(degerler); // Ancak bunun için dönüş değerim de degerler olmalı.
        }
    }
}