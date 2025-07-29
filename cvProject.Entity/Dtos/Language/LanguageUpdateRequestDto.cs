using Core.Entities;

namespace cvProject.Entity.Dtos.Language
{
    public sealed record LanguageUpdateRequestDto(
        Guid Id,
        string Name,
        byte Level,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;


}
