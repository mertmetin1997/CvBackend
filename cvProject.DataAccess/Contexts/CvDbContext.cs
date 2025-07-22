using cvProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cvProject.DataAccess.Contexts
{
    public sealed class CvDbContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experince> Experinces { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }
    }
}
