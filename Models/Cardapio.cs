using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TccAds.Models
{
    public class Cardapio
    {
        public int ID { get; set; }
        public string Prato { get; set; }
        public string Dia { get; set; }
        public int Acompanhamentos { get; set; }
    }
}