﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VenusTicariOtomasyon.Models.Siniflar
{
    public class Departmanlar
    {
        [Key]
        public int DepartmanID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmanAd { get; set; }
        public bool Durum { get; set; }
        public ICollection<Personeller> Personellers { get; set; }
    }
}