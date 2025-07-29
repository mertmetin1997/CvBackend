using AutoMapper;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.About;
using cvProject.Entity.Dtos.Certificate;
using cvProject.Entity.Dtos.Contact;
using cvProject.Entity.Dtos.Education;
using cvProject.Entity.Dtos.Experience;
using cvProject.Entity.Dtos.Interest;
using cvProject.Entity.Dtos.Language;
using cvProject.Entity.Dtos.PersonalInfo;
using cvProject.Entity.Dtos.Skill;
using cvProject.Entity.Dtos.SocialAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Mappers.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<About, AboutResponseDto>();
            CreateMap<About, AboutDetailResponseDto>();
            CreateMap<AboutCreateRequestDto, About>();
            CreateMap<AboutUpdateRequestDto, About>();

            CreateMap<Certificate, CertificateResponseDto>();
            CreateMap<Certificate, CertificateDetailResponseDto>();
            CreateMap<CertificateCreateRequestDto, Certificate>();
            CreateMap<CertificateUpdateRequestDto, Certificate>();

            CreateMap<Contact, ContactResponseDto>();
            CreateMap<Contact, ContactDetailResponseDto>();
            CreateMap<ContactCreateRequestDto, Contact>();
            CreateMap<ContactUpdateRequestDto, Contact>();

            CreateMap<Education, EducationResponseDto>();
            CreateMap<Education, EducationDetailResponseDto>();
            CreateMap<EducationCreateRequestDto, Education>();
            CreateMap<EducationUpdateRequestDto, Education>();

            CreateMap<Experience, ExperienceResponseDto>();
            CreateMap<Experience, ExperienceDetailResponseDto>();
            CreateMap<ExperienceCreateRequestDto, Experience>();
            CreateMap<ExperienceUpdateRequestDto, Experience>();

            CreateMap<Interest, InterestResponseDto>();
            CreateMap<Interest, InterestDetailResponseDto>();
            CreateMap<InterestCreateRequestDto, Interest>();
            CreateMap<InterestUpdateRequestDto, Interest>();

            CreateMap<Language, LanguageResponseDto>();
            CreateMap<Language, LanguageDetailResponseDto>();
            CreateMap<LanguageCreateRequestDto, Language>();
            CreateMap<LanguageUpdateRequestDto, Language>();

            CreateMap<PersonalInfo, PersonalInfoResponseDto>();
            CreateMap<PersonalInfo, PersonalInfoDetailResponseDto>();
            CreateMap<PersonalInfoCreateRequestDto, PersonalInfo>();
            CreateMap<PersonalInfoUpdateRequestDto, PersonalInfo>();

            CreateMap<Skill, SkillResponseDto>();
            CreateMap<Skill, SkillDetailResponseDto>();
            CreateMap<SkillCreateRequestDto, Skill>();
            CreateMap<SkillUpdateRequestDto, Skill>();

            CreateMap<SocialAccount, SocialAccountResponseDto>();
            CreateMap<SocialAccount, SocialAccountDetailResponseDto>();
            CreateMap<SocialAccountCreateRequestDto, SocialAccount>();
            CreateMap<SocialAccountUpdateRequestDto, SocialAccount>();
        }
    }
}
