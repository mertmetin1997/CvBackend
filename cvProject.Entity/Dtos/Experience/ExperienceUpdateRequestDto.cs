using Core.Entities;

namespace cvProject.Entity.Dtos.Experience
{
    public sealed record ExperienceUpdateRequestDto(
        Guid Id,
        string Title,
        string Company,
        string Description,
        DateTime StartDate,
        DateTime? EndDate,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;


}
