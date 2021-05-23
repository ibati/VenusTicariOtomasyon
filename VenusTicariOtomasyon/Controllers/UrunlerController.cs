using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using VenusTicariOtomasyon.Models.Siniflar;

namespace VenusTicariOtomasyon.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Urunlers.Where(x => x.Durum == true).ToList();
            return View(urunler);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> kategorilerigetir = (from x in c.Kategorilers.ToList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.KategoriAd,
                                                          Value = x.KategoriID.ToString()
                                                      }).ToList();
            ViewBag.kategoriler = kategorilerigetir;
            return View();

        }

        [HttpPost]
        public ActionResult UrunEkle(Urunler u)
        {
            c.Urunlers.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunSil(int id)
        {
            var urun = c.Urunlers.Find(id);
            urun.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult UrunGetir(int id)
        {
            var urun = c.Urunlers.Find(id);
            List<SelectListItem> kategorilerigetir = (from x in c.Kategorilers.ToList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.KategoriAd,
                                                          Value = x.KategoriID.ToString()
                                                      }).ToList();
            ViewBag.kategoriler = kategorilerigetir;
            return View("UrunGetir", urun);
        }

        public ActionResult UrunGuncelle(Urunler u)
        {
            var urun = c.Urunlers.Find(u.UrunID);
            urun.UrunAd = u.UrunAd;
            urun.Marka = u.Marka;
            urun.AlisFiyat = u.AlisFiyat;
            urun.SatisFiyat = u.SatisFiyat;
            urun.Stok = u.Stok;
            urun.KategoriID = u.KategoriID;
            urun.UrunGorsel = u.UrunGorsel;
            urun.Durum = u.Durum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}