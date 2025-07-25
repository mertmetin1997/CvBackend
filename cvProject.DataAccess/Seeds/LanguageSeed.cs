using cvProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.DataAccess.Seeds
{
    internal class LanguageSeed : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new Language()
                {
                     Id = Guid.NewGuid(),
                     Name = "İngilizce",
                     Level = 80
                },
                new Language()
                {
                     Id = Guid.NewGuid(),
                     Name = "Almanca",
                     Level = 60
                }
            );
        }
    }
}
