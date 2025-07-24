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
    internal class SocialAccountConfiguration : IEntityTypeConfiguration<SocialAccount>
    {
        public void Configure(EntityTypeBuilder<SocialAccount> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(20).IsRequired();
            builder.Property(s => s.WebUrl).HasMaxLength(50).IsRequired();
            builder.Property(s => s.UserName).HasMaxLength(30).IsRequired();
            builder.Property(s => s.Icon).HasMaxLength(30).IsRequired();
        }
    }
}
