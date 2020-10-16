using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Autoprevoznicko_preduzece_HTS.Model;
using WebAutoprevozncniko.ViewModels;

namespace WebAutoprevozncniko.Controllers

{
    public class PretragaController : Controller
    {
     
       public JsonResult getPutniciByZona(int id)
        {
            MyContext db = new MyContext();
            var lista = new List<KupacPrikaziWM>();
            foreach(var x in db.karta.Include(x => x.kupac).Where(l=>l.gradskaLinija.zonaID == id))  
            {
                lista.Add(new KupacPrikaziWM
                {
                    ID = x.kupacID,
                    Ime = x.kupac.ime,
                    Prezime = x.kupac.prezime
                });
            }
            return Json(lista);
        }
    }
}