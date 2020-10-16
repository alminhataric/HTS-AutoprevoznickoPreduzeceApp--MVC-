using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autoprevoznicko_preduzece_HTS.Model;
using WebAutoprevozncniko.ViewModels;

namespace WebAutoprevozncniko.Controllers
{
    public class ObavijestiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PregledObavijesti()
        {
            MyContext db = new MyContext();
            List<PrikaziObavijestiVM> obavijesti = db.obavijesti.Select(o => new PrikaziObavijestiVM
            {
                ID = o.ID,
                naslov=o.naslov,
                sadrzaj=o.sadrzaj,
                datumObjave=o.datumObjave,
                uprava=o.uprava.Ime+o.uprava.Prezime
            }).ToList();
            ViewData["obavijesti"] = obavijesti;
            return View();
        }
        public IActionResult DodajObavijest()
        {
            MyContext db = new MyContext();
            List<ComboBox> uprava = db.uprava.Select(u => new ComboBox
            {
                ID = u.ID,
                naziv=u.Ime + " " + u.Prezime
            }).ToList();
            ViewData["uprava"] = uprava;
            return View();
        }
        public IActionResult SpasiObavijest(
            string naslov,
            string sadrzaj,
            DateTime datum,
            int autorID
            )
        {
            MyContext db = new MyContext();
            Obavijesti o = new Obavijesti
            {
                naslov = naslov,
                sadrzaj = sadrzaj,
                datumObjave = datum,
                upravaID = autorID
                
            };
            db.Add(o);
            db.SaveChanges();
            return Redirect(url: "/Obavijesti/ObavijestiPoruka");
        }
        public IActionResult ObavijestiPoruka()
        {
            return View();
        }
        public IActionResult ObrisiObavijest(int ID)
        {
            MyContext db = new MyContext();
            Obavijesti o = db.obavijesti.Find(ID);
            db.Remove(o);
            db.SaveChanges();
            return Redirect(url:"/Obavijesti/ObrisiPoruka");
        }
        public IActionResult ObrisiPoruka()
        {
            return View();
        }
        public IActionResult UrediObavijest(int ID)
        {
            MyContext db = new MyContext();
            List<ComboBox> uprava = db.uprava.Select(u => new ComboBox
            {
                ID = u.ID,
                naziv = u.Ime + " " + u.Prezime
            }).ToList();
            ViewData["uprava"] = uprava;
            Obavijesti o = db.obavijesti.Find(ID);
            ViewData["Obavijesti"] = o;
            return View();
        }
        public IActionResult SpasiUredjivanje(
            int ID,
                 string naslov,
            string sadrzaj,
            DateTime datum,
            int autorID
            )
        {
            MyContext db = new MyContext();
            Obavijesti o = db.obavijesti.Find(ID);
            if (ID != 0)
            {
                o.naslov = naslov;
                o.sadrzaj = sadrzaj;
                o.datumObjave = datum;
                o.upravaID = autorID;
            }
            db.SaveChanges();
            db.Dispose();
            return Redirect(url: "/Obavijesti/UrediPoruka");
        }
        public IActionResult UrediPoruka()
        {
            return View();
        }
    }
}