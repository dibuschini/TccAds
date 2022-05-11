using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TccAds.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string UsrNome { get; set; }
        public string UsrEmail { get; set; }
        public string UsrSenha { get; set; }
        public string UsrRua { get; set; }
        public int UsrNum { get; set; }
        public string UsrBairro { get; set; }
        public string UsrCidade { get; set; }
     
    }
}