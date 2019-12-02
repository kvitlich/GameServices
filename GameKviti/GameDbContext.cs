using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameKviti
{
    public class GameDbContext : DbContext
    {
        public GameDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KVITLICH;Database=GameArchive;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Game first = new Game
            {
                Name = "Mario",
                Genre = "Arcade",
                Description = "Mario it's Mario",
                Realise = "15 декабря 203",
                Logo = new Uri(@"https://upload.wikimedia.org/wikipedia/ru/thumb/1/15/Mario2small.jpg/274px-Mario2small.jpg"),
            };
            modelBuilder.Entity<Game>().HasData(first);
        }
    }
}
