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
            builder.Property(t => t.Category).IsRequired();
            builder.Property(t => t.estimatedTime).IsRequired();
            builder.Property(t => t.estimationUnit).IsRequired().HasDefaultValue("minute");
            builder.Property(t => t.Category).IsRequired();
            builder.Property(t => t.Category).IsRequired();
            builder.Property(t => t.Category).IsRequired();
            builder.Property(t => t.Category).IsRequired();
        }
    }
}