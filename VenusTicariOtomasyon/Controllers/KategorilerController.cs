using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VenusTicariOtomasyon.Models.Siniflar;

namespace VenusTicariOtomasyon.Controllers
{
    public class KategorilerController : Controller
    {
        // GET: Kategoriler
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Kategorilers.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategoriler k)
        {
            c.Kategorilers.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult KategoriSil(int id)
        {
            var kategori = c.Kategorilers.Find(id);
            c.Kategorilers.Remove(kategori);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategorilers.Find(id);
            return View("KategoriGetir", kategori);

        }

        public ActionResult KategoriGuncelle(Kategoriler k)
        {
            var kategori = c.Kategorilers.Find(k.KategoriID);
            kategori.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}