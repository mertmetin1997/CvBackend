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
    internal class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
    {
        public void Configure(EntityTypeBuilder<PersonalInfo> builder)
        {
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.ImageUrl).HasMaxLength(100);
            builder.Property(p => p.MaritalStatus).HasColumnType("bit");
            builder.Property(p => p.Gender).HasConversion<string>().HasMaxLength(10).IsRequired();
            builder.Property(p => p.DrivingLicence).HasMaxLength(10).HasDefaultValue("No");
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.BirthPlace).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Nationality).HasMaxLength(50).HasDefaultValue("Türkiye");
        }
    }
}
