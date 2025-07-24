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
    internal class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.Property(s => s.Title).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Icon).HasMaxLength(500).IsRequired();
            builder.Property(s => s.IsProgramLanguageAndTool).HasColumnType("bit").IsRequired();

        }
    }
}
