using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AppTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.SeedUsers(modelBuilder);
        }

        private void SeedUsers(ModelBuilder builder)  
        {  
            User user = new User()  
            {  
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",  
                UserName = "IDO User",  
                Email = "user@ido.com",  
                LockoutEnabled = false
            };  
  
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();  
            user.PasswordHash = passwordHasher.HashPassword(user, "Pa$$w0rd");
            builder.Entity<User>().HasData(user);  
        }
    }
}