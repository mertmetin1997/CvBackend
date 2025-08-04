using Autofac;
using Core.DataAccess;
using Core.UnitOfWorks;
using cvProject.Business.Abstract;
using cvProject.Business.Concrete;
using cvProject.DataAccess.Abstract;
using cvProject.DataAccess.Concrete.EntityFramework;
using cvProject.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Dependency_Resolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfAboutRepository>().As<IAboutRepository>();
            builder.RegisterType<AboutManager>().As<IAboutService>();
            
            builder.RegisterType<EfCerfiticateRepository>().As<ICertificateRepository>();
            builder.RegisterType<CertificateManager>().As<ICertificateService>();

            builder.RegisterType<EfContactRepository>().As<IContactRepository>();
            builder.RegisterType<ContactManager>().As<IContactService>();

            builder.RegisterType<EfEducationRepository>().As<IEducationRepository>();
            builder.RegisterType<EducationManager>().As<IEducationService>();

            builder.RegisterType<EfExperienceRepository>().As<IExperienceRepository>();
            builder.RegisterType<ExperienceManager>().As<IExperienceService>();

            builder.RegisterType<EfInterestRepository>().As<IInterestRepository>();
            builder.RegisterType<InterestManager>().As<IInterestService>();

            builder.RegisterType<EfLanguageRepository>().As<ILanguageRepository>();
            builder.RegisterType<LanguageManager>().As<ILanguageService>();

            builder.RegisterType<EfPersonalInfoRepository>().As<IPersonalInfoRepository>();
            builder.RegisterType<PersonalInfoManager>().As<IPersonalInfoService>();

            builder.RegisterType<EfSkillRepository>().As<ISkillRepository>();
            builder.RegisterType<SkillManager>().As<ISkillService>();

            builder.RegisterType<EfSocialAccountRepository>().As<ISocialAccountRepository>();
            builder.RegisterType<SocialManager>().As<ISocialAccountService>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
