using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IdleGame1.Models
{
    public class GameDataContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}