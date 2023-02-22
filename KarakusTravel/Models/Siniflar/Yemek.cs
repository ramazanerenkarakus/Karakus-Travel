using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KarakusTravel.Models.Siniflar
{
    public class Yemek
    {
        [Key]
        public int ID { get; set; }
        public int YemekBaslik { get; set; }
        public int Aciklama { get; set; }
        public int YemekIMage { get; set; }
    }
}