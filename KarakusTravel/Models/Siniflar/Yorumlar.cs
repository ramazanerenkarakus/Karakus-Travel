using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KarakusTravel.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; } /*2.blog Blog sınıfımdan gelecek değerimi tutuyor. Virtual ekledim yoksa her yorum 
                                                eklediğimde yeni bir blog ekleyecekti yeni id ile birlikte. İsmi baslik ve açıklaması
                                                olmayan bloglar. Bunun önüne geçebilmek adına virtual ekledim*/
    }
}