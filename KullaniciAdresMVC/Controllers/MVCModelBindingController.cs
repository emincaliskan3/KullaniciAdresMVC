using KullaniciAdresMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KullaniciAdresMVC.Controllers
{
    public class MVCModelBindingController : Controller
    {
        // GET: MVCModelBinding
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KullaniciDetay()

        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Emin",
                Soyad = "Çalışkan",
                Email = "messi@hot.com",
                KullaniciAdi = " emin",
                Sifre = "123"

            };

            ViewBag.KullaniciAdSoyad = kullanici.Ad + "" + kullanici.Soyad;

            return View(kullanici);
        }
        [HttpPost]
        public ActionResult KullaniciDetay(Kullanici kullanici)
        {

            return View(kullanici);
        }


        public ActionResult AdresDetay()
        {
            Adres adres = new Adres();
            adres.Sehir = "İstanbul";
            adres.Ilce = "Şişli";
            adres.AcikAdres = "Mecidiyeköy";
            return View(adres);
        }
        [HttpPost]
        public ActionResult AdresDetay(Adres adres)
        {
            return View(adres);
        }
        public ActionResult KullaniciAdresDetay()
        {
            var model = new KullaniciAdresDetayViewModel();
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Emin",
                Soyad = "Çalışkan",
                Email = "messi@hot.com",
                KullaniciAdi = " emin",
                Sifre = "123"

            };
            Adres adres = new Adres();
            adres.Sehir = "İstanbul";
            adres.Ilce = "Şişli";
            adres.AcikAdres = "Mecidiyeköy";

            model.Adres = adres;
            model.Kullanici = kullanici;

            return View(model);
        }
    }
}