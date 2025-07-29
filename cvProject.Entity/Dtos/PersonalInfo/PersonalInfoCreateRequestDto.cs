using Core.Entities;

namespace cvProject.Entity.Dtos.PersonalInfo
{
    public sealed record PersonalInfoCreateRequestDto(
        string FirstName,
        string LastName,
        string ImageUrl,
        bool MaritalStatus,
        string DrivingLicence,
        DateTime BirthDate,
        string Gender,
        string BirthPlace,
        string Nationality
        ) : ICreateDto;


}
