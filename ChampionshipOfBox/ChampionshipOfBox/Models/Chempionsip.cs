using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChampionshipOfBox.Models
{
    public class Chempionsip
    {
        public int Ranking { get; set; }
        [Key]
        public string Name { get; set; }
        public int NumberOfBattle { get; set; }
    }
}