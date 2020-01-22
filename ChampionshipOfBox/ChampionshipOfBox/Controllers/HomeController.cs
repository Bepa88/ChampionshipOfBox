using ChampionshipOfBox.DataModel;
using ChampionshipOfBox.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ChampionshipOfBox.Controllers
{
    public class HomeController : Controller
    {
        BattleContext db = new BattleContext();

        public ActionResult Chempionsip()
        {
            return View();
        }

        public ActionResult Main()
        {
            IEnumerable<Chempionsip> chempionsip = db.Chempionsip;
            ViewBag.Chempionsip = chempionsip;
            return View();
        }


        public ActionResult Battle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Battle(Battle battle)
        {
            db.Battle.Add(battle);
            db.SaveChanges();

            return View("Chempionsip");
        }

        public string GetData()
        {
            IEnumerable<Battle> battles = db.Battle;
            return JsonConvert.SerializeObject(battles);
        }

        [HttpPost]
        public void Edit(Battle battle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(battle).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        [HttpPost]
        public void Create(Battle battle)
        {
            db.Battle.Add(battle);
            db.SaveChanges();
        }
    }
}