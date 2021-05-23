using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VenusTicariOtomasyon.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Departmanlar> Departmanlars { get; set; }
        public DbSet<Faturalar> Faturalars { get; set; }
        public DbSet<FaturaSatirlari> FaturaSatirlaris { get; set; }
        public DbSet<Giderler> Giderlers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        public DbSet<SatisHareketleri> SatisHareketleris { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Yoneticiler> Yoneticilers { get; set; }
    }
}