using FoxManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Entities
{
    public class FoxManagerContext: DbContext
    {
        public FoxManagerContext(DbContextOptions<FoxManagerContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Division> Divisions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(p => p.Projects)
                .WithOne(u => u.Student).IsRequired();

            modelBuilder.Entity<Project>()
                .HasOne(u => u.Student)
                .WithMany(p => p.Projects).IsRequired();

            modelBuilder.Entity<Division>()
               .HasMany(p => p.Teams)
               .WithOne(u => u.Division).IsRequired();

            modelBuilder.Entity<Team>()
                .HasOne(u => u.Division)
                .WithMany(p => p.Teams).IsRequired();
        }

 
            


    }
}