using Core.Entities;

namespace cvProject.Entity.Dtos.PersonalInfo
{
    public sealed record PersonalInfoUpdateRequestDto(
        Guid Id,
        string FirstName,
        string LastName,
        string ImageUrl,
        bool MaritalStatus,
        string DrivingLicence,
        DateTime BirthDate,
        string Gender,
        string BirthPlace,
        string Nationality,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;


}
