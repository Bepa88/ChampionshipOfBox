using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampionshipOfBox.Models
{
    public class Battle
    {
        public int Id { get; set; }
        public DateTime BattleDateTime { get; set; }
        public string Winner { get; set; }
        public string Loser { get; set; }
        public int RefereePoints { get; set; }
    }
}