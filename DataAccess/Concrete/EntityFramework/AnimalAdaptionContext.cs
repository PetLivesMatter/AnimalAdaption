using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class AnimalAdaptionContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=AnimalAdaption;Trusted_Connection=true;")
        }

        public DbSet<Animals> Animals { get; set; }
        public DbSet<Advertisements> Advertisements { get; set; }
        public DbSet<AnimalTypes> AnimalTypes { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
