using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChampionshipOfBox.Models
{
    [Table("Chempionsip")]
    public class Chempionsip
    {
        public int Ranking { get; set; }
        [Key]
        public string Name { get; set; }
        public int NumberOfBattle { get; set; }
    }
}