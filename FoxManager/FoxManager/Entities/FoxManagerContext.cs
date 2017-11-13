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
    }
}