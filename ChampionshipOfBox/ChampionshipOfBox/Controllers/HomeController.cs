using ChampionshipOfBox.DataModel;
using ChampionshipOfBox.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public string GetData()
        {
            IEnumerable<Battle> battles = db.Battle;
            return JsonConvert.SerializeObject(battles);
        }
    }
}