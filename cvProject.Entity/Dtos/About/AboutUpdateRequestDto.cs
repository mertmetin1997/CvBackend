using Core.Entities;

namespace cvProject.Entity.Dtos.About
{
    public sealed record AboutUpdateRequestDto(
        Guid Id,
        string Description,
        byte Order,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;
}
