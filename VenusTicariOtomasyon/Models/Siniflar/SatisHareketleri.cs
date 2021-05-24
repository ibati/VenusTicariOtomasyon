using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VenusTicariOtomasyon.Models.Siniflar
{
    public class SatisHareketleri
    {
        [Key]
        public int SatisID { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public int UrunID { get; set; }
        public int CariID { get; set; }
        public int PersonelID { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual Cariler Cariler { get; set; }
        public virtual Personeller Personeller { get; set; }
    }
}
