using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace IdleGame1.Models
{
    public class GameDataInitializer : DropCreateDatabaseIfModelChanges<GameDataContext>
    {

        protected override void Seed(GameDataContext context)
        {
            GetBuildings().ForEach(b => context.Buildings.Add(b));
            GetResources().ForEach(r => context.Resources.Add(r));
        }

        private static List<Building> GetBuildings()
        {
            var buildings = new List<Building> {
                new Building
                {
                    BuildingID = 1,
                    Name = "Colony Hub",
                    Description = "The core of every colony.  Without this, everyone dies.",
                    UnitPrice = 0.0,
                    Quantity = 1,
                    Unlocked = true,
                    Buildable = false

                },
                new Building
                {
                    BuildingID = 2,
                    Name = "Mine",
                    Description = "A gouge in the planet that leads to that sweet sweet metal.",
                    UnitPrice = 0.0,
                    Quantity = 1,
                    Unlocked = true,
                    Buildable = true
                },
                new Building
                {
                    BuildingID = 3,
                    Name = "Space Station",
                    Description = "An artificial satelite serving as a platform for housing puppies.",
                    UnitPrice = 0.0,
                    Quantity = 0,
                    Unlocked = false,
                    Buildable = false
                }
                
            };

            return buildings;
        }

        private static List<Resource> GetResources()
        {
            var resources = new List<Resource> {
                new Resource
                {
                    ResourceID = 1,
                    Name = "Metal",
                    Description = "Basic resource for buildings",
                    Quantity = 100,
                    Unlocked = true
               }
                
            };

            return resources;
        }
    }
}