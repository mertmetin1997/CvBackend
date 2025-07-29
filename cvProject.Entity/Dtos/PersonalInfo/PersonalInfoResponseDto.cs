using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Dtos.PersonalInfo
{
    public sealed record PersonalInfoResponseDto(
        Guid Id,
        string FirstName,
        string LastName,
        string ImageUrl,
        bool MaritalStatus,
        string DrivingLicence,
        DateTime BirthDate,
        string Gender,
        string BirthPlace,
        string Nationality
        ) : IResponseDto;


}
