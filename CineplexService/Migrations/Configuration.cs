namespace CineplexService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CineplexService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CineplexService.Models.CineplexServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CineplexService.Models.CineplexServiceContext context)
        {
context.Movie30022962.AddOrUpdate(p => p.Name,
    new Movie30022962 { 
        Name = "The Martian", 
        Duration = "150 mins",
        Genre = "Action",
        Rating = 8,
        Price = 35.00f,
        Description = "An astronaut is marooned on Mars."
    }, 
    new Movie30022962 {
        Name = "Interstellar", 
        Duration = "190 mins",
        Genre = "Action",
        Rating = 8,
        Price = 30.00f,
        Description = "An astronaut goes through a Wormhole then a Blackhole."

    });
        }
    }
}
