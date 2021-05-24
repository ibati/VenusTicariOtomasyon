using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VenusTicariOtomasyon.Models.Siniflar;

namespace VenusTicariOtomasyon.Controllers
{
    public class DepartmanlarController : Controller
    {
        // GET: Departmanlar
        Context c = new Context();
        public ActionResult Index()
        {
            var departmanlar = c.Departmanlars.Where(x => x.Durum == true).ToList();
            return View(departmanlar);
        }

        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();

        }

        [HttpPost]
        public ActionResult DepartmanEkle(Departmanlar d)
        {
            c.Departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanSil(int id)
        {
            var departman = c.Departmanlars.Find(id);
            departman.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanGetir(int id)
        {
            var departman = c.Departmanlars.Find(id);
            return View("DepartmanGetir", departman);

        }

        public ActionResult DepartmanGuncelle(Departmanlar d)
        {
            var departman = c.Departmanlars.Find(d.DepartmanID);
            departman.DepartmanAd = d.DepartmanAd;
            departman.Durum = d.Durum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanDetay(int id)
        {
            var personel = c.Personellers.Where(x => x.DepartmanID == id).ToList();
            var departman = c.Departmanlars.Where(x => x.DepartmanID == id).Select(y => y.DepartmanAd).FirstOrDefault();
            ViewBag.departman = departman;
            return View(personel);
        }

        public ActionResult DepartmanPersonelSatis(int id)
        {
            var satislar = c.SatisHareketleris.Where(x => x.PersonelID == id).ToList();
            var personel = c.Personellers.Where(x => x.PersonelID == id).Select(y => y.PersonelAd +" "+  y.PersonelSoyad).FirstOrDefault();
            ViewBag.personel = personel;
            return View(satislar);
        }

    }
}