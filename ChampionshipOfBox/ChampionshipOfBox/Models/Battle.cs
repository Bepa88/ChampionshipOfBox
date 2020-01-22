using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChampionshipOfBox.Models
{
    [Table("Battle")]
    public class Battle
    {
        public int Id { get; set; }
        public DateTime BattleDateTime { get; set; }
        public string Winner { get; set; }
        public string Loser { get; set; }
        public int RefereePoints { get; set; }
    }
}