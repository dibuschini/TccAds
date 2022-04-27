using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TccAds.Models;

namespace TccAds.Dal
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Unifaat") {}

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Mesas> Mesas { get; set; }
    }
}