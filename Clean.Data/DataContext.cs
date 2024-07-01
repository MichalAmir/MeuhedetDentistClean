using Clean.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Clean.Data
{
    public class DataContext : DbContext
    {
        public DbSet<clients> Clients { get; set; }
        public DbSet<doctors> Doctors { get; set; }
        public DbSet<turns> Turns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
    }
}