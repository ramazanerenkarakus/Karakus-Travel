using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KarakusTravel.Models.Siniflar
{
    public class Otel
    {
        [Key]
        public int ID { get; set; }
        public int OtelBaslik { get; set; }
        public int Aciklama { get; set; }
        public int OtelIMage { get; set; }
    }
}