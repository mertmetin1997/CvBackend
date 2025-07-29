using Core.Entities;

namespace cvProject.Entity.Dtos.Interest
{
    public sealed record InterestUpdateRequestDto(
        Guid Id,
        string Description,
        byte Order,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;


}
