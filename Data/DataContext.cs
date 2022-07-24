using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<AppTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Estimate>().HasNoKey();
            // modelBuilder.Entity<AppTask>()
            // .HasOne<Estimate>(s => s.Estimate)
            // .WithOne(ad => ad.AppTask)
            // .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);
        }
    }
}