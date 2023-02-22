using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarakusTravel.Models.Siniflar
{
    public class BlogYorum //BU SINIF BENİM BLOGLARIMA YAPACAĞIM YORUMLARI LİSTELEMEM İÇİN GEREKLİ OLAN SINIF
    {
        public IEnumerable<Blog> Deger1 { get; set; } //Blog'dan geleceklerin isimlerine Deger1 dedim
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; } //Son yorumları listelemek için bir deger'e daha ihtiyacım vardı. Yine blog'dan gelecek getireceği değerler farklı olacak
    }
}