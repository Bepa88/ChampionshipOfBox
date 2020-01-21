using ChampionshipOfBox.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChampionshipOfBox.DataModel
{
    public class BattleContext : DbContext
    {
        public BattleContext() :
            base("BattleDB")
        {
            Database.SetInitializer<BattleContext>(null);
        }

        public DbSet<Battle> Battle { get; set; }
        public DbSet<Chempionsip> Chempionsip { get; set; }
    }
}