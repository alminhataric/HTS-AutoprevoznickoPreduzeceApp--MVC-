using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autoprevoznicko_preduzece_HTS.Model;

namespace WebAutoprevozncniko.Controllers
{
    public class GradController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListaGradova()
        {
            MyContext db = new MyContext();
            List<Grad> gradovi = db.grad.ToList();
            ViewData["Gradovi"] = gradovi;
            return View();
        }
        public IActionResult DodajGrad()
        {
            return View();
        }
        public IActionResult SpasiGrad(
                string NazivGrada,
                int PostanskiBroj
            )
        {
            MyContext db = new MyContext();
            Grad g = new Grad
            {
                nazivGrada = NazivGrada,
                PostanskiBroj = PostanskiBroj
            };
            db.Add(g);
            db.SaveChanges();
            db.Dispose();
            TempData["Grad"] = NazivGrada;
            return Redirect(url: "/Grad/GradPoruka");
        }
        public IActionResult GradPoruka()
        {
            return View();
        }
        public IActionResult ObrisiGrad(int ID)
        {
            MyContext db = new MyContext();
            Grad g = db.grad.Find(ID);
            db.Remove(g);
            db.SaveChanges();
            db.Dispose();
            TempData["Grad"] = g.nazivGrada;
            return Redirect(url: "/Grad/ObrisiPoruka");
        }
        public IActionResult ObrisiPoruka()
        {
            return View();
        }
        public IActionResult UrediGrad(int ID)
        {
            MyContext db = new MyContext();
            Grad g = db.grad.Find(ID);
            ViewData["Grad"] = g;
            return View();
        }
        public IActionResult SpasiUredjivanje(
            int ID,
            string NazivGrada,
            int PostanskiBroj
            )
        {
            MyContext db = new MyContext();
            Grad g = db.grad.Find(ID);
            if (ID != 0)
            {
                g.nazivGrada = NazivGrada;
                g.PostanskiBroj = PostanskiBroj;
            }
            db.SaveChanges();
            db.Dispose();
            return Redirect(url: "/Grad/UrediPoruka");
        }
        public IActionResult UrediPoruka()
        {
            return View();
        }
    }
}