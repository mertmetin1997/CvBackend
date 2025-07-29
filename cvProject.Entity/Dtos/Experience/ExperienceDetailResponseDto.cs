using Core.Entities;

namespace cvProject.Entity.Dtos.Experience
{
    public sealed record ExperienceDetailResponseDto(
        Guid Id,
        string Title,
        string Company,
        string Description,
        DateTime StartDate,
        DateTime? EndDate,
        bool IsActive,
        bool IsDeleted
        ) : IDetailDto;


}
