using cvProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.DataAccess.Configurations
{
    internal class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.Property(e => e.School).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Section).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Department).HasMaxLength(50);
            builder.Property(e => e.GPA).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.Grade).HasMaxLength(20).IsRequired();
        }
    }
}
