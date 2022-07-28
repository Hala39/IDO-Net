using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<AppTask>
    {
        public void Configure(EntityTypeBuilder<AppTask> builder)
        {
            builder.Property(t => t.Category).HasColumnType("varchar").HasMaxLength(500);
            builder.Property(t => t.Title).HasColumnType("varchar").IsRequired().HasMaxLength(500);
            builder.Property(t => t.estimatedTime).HasColumnType("SMALLINT");
            builder.Property(t => t.estimationUnit).HasColumnType("varchar").HasMaxLength(500);
            builder.Property(t => t.DueDate).HasDefaultValue(null);
            builder.Property(t => t.Date).HasDefaultValue(DateTime.Now).HasConversion<string>().IsRequired();
            builder.Property(t => t.Status).HasDefaultValue(Status.TODO);
            builder.Property(t => t.Importance).HasDefaultValue(Importance.LOW).HasConversion<string>();

            // Relationship Config
            builder.HasOne<User>(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId);

        }
    }
}