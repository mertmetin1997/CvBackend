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
    internal class ExperinceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.Property(e => e.Title).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Company).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(500).IsRequired();
            builder.Property(e => e.StartDate).IsRequired();
        }
    }
}
