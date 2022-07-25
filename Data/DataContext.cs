using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        private string Id { get; set;} = "b74ddd14-6340-4840-95c2-db12554843e5";
        private readonly IMapper _mapper;
        public DataContext(DbContextOptions<DataContext> options, IMapper mapper) : base(options)
        {
            _mapper = mapper;
        }

        public DbSet<AppTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.SeedUsers(modelBuilder);
            this.SeedTasks(modelBuilder);
        }

        private void SeedUsers(ModelBuilder builder)  
        {  
            User user = new User()  
            {  
                Id = this.Id,  
                UserName = "IDO User",  
                Email = "user@ido.com",  
                LockoutEnabled = false
            };  
  
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();  
            user.PasswordHash = passwordHasher.HashPassword(user, "Pa$$w0rd");
            builder.Entity<User>().HasData(user);  
        }

        private void SeedTasks(ModelBuilder builder)
        {
            List<NewTaskDto> tasks = new List<NewTaskDto>() {
                new NewTaskDto()
                {
                    Id = -7,
                    Title = "Prepare the essay",
                    Category = "Education",
                    DueDate = DateTime.Now.AddDays(3),
                    estimatedTime = 6,
                    estimationUnit = Unit.HOUR,
                    Importance = Importance.HIGH,
                    UserId = this.Id
                },

                new NewTaskDto()
                {
                    Id = -6,
                    Title = "Format the PC",
                    Category = "Maintenance",
                    DueDate = DateTime.Now.AddDays(13),
                    estimatedTime = 3,
                    estimationUnit = Unit.HOUR,
                    Importance = Importance.LOW,
                    UserId = this.Id
                },

                new NewTaskDto()
                {
                    Id = -5,
                    Title = "Contact the support team of XYZ software to ask about the guarantee pricing",
                    Category = "Maintenance",
                    DueDate = DateTime.Now.AddDays(2),
                    estimatedTime = 30,
                    estimationUnit = Unit.MINUTE,
                    Importance = Importance.MEDIUM,
                    UserId = this.Id
                },

                new NewTaskDto()
                {
                    Id = -4,
                    Title = "Translate the resume",
                    Category = "Work",
                    DueDate = DateTime.Now.AddDays(16),
                    estimatedTime = 2,
                    estimationUnit = Unit.HOUR,
                    Importance = Importance.LOW,
                    UserId = this.Id
                },

                new NewTaskDto()
                {
                    Id = -3,
                    Title = "Fix the power button of the TV",
                    Category = "Maintenance",
                    estimatedTime = 1,
                    estimationUnit = Unit.HOUR,
                    Importance = Importance.MEDIUM,
                    UserId = this.Id
                },

                new NewTaskDto()
                {
                    Id = -2,
                    Title = "Prepare the XD design",
                    Category = "Work",
                    DueDate = DateTime.Now.AddDays(8),
                    estimatedTime = 8,
                    estimationUnit = Unit.DAY,
                    Importance = Importance.HIGH,
                    UserId = this.Id
                },

                new NewTaskDto()
                {
                    Id = -1,
                    Title = "Email the faculity director about the progress",
                    Category = "Education",
                    estimatedTime = 15,
                    estimationUnit = Unit.MINUTE,
                    UserId = this.Id
                }

            };

            var mapped = tasks.Select(t => _mapper.Map<AppTask>(t)).ToList();

            builder.Entity<AppTask>().HasData(mapped);
            
        }
    }
}