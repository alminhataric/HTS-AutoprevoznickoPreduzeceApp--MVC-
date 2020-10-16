using System.Collections.Generic;
using System.Linq;
using Autoprevoznicko_preduzece_HTS.Model;
using Microsoft.AspNetCore.Mvc;
using WebAutoprevozncniko.ViewModels;

namespace WebAutoprevozncniko.Controllers
{
    public class KupacController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PrikaziKupce()
        {
            MyContext db = new MyContext();
            List<KupacPrikaziWM> kupci = db.kupac.Select(k=>new KupacPrikaziWM { 
                ID=k.ID,
                Ime=k.ime,
                Prezime=k.prezime,
                Grad=k.grad.nazivGrada
            }).ToList();

            ViewData["kupci"] = kupci;
            return View();
        }
        public IActionResult DodajKupca()
        {
            MyContext db = new MyContext();
            List<GradoviWM> gradovi = db.grad.Select(g => new GradoviWM
            {
                ID = g.ID,
                naziv = g.nazivGrada,
            }).ToList();
            ViewData["gradovi"] = gradovi;
            return View();
        }
        public IActionResult SpasiKupca(
            string ime,
            string prezime,
            int GradID
            )
        {
            MyContext db = new MyContext();
            Kupac k = new Kupac
            {
              ime=ime,
              prezime=prezime,
              gradID=GradID
            };

            db.Add(k);
            db.SaveChanges();
            db.Dispose();
            EmailController.SendEmail("adin.smajkic@gmail.com", "Korisnički podaci", "Korisnčko ime: " + ime + " Šifra: " + prezime);
            TempData["Ime"] = k.ime + " " + k.prezime;
            return Redirect(url:"/Kupac/SpasiPoruka");
        }
        public IActionResult SpasiPoruka()
        {
            return View();
        }
        public IActionResult ObrisiKupca(int KupacID)
        {
            MyContext db = new MyContext();
            Kupac k = db.kupac.Find(KupacID);
            db.Remove(k);
            db.SaveChanges();
            TempData["ImeIprezime"] = k.ime + " " + k.prezime;
            return Redirect(url: "/Kupac/ObrisiPoruka");
        }
        public IActionResult ObrisiPoruka()
        {
            return View();
        }
        public IActionResult UrediKupca(int KupacID)
        {
            MyContext db = new MyContext();
            List<GradoviWM> gradovi = db.grad.Select(g => new GradoviWM
            {
                ID = g.ID,
                naziv = g.nazivGrada,
            }).ToList();
            ViewData["gradovi"] = gradovi;
            Kupac k = db.kupac.Find(KupacID);
            ViewData["kupac"] = k;
            return View();
        }
        public IActionResult SpasiUredjivanje(
            int KupacID,
            string ime,
            string prezime,
            int gradID
            )
        {
            MyContext db = new MyContext();
            Kupac k = db.kupac.Find(KupacID);
            if (KupacID != 0)
            {
                k.ime = ime;
                k.prezime = prezime;
                k.gradID = gradID;
            }
            db.SaveChanges();
            db.Dispose();
            return Redirect(url: "/Kupac/UrediPoruka");
        }
        public IActionResult UrediPoruka()
        {
            return View();
        }
    }
}