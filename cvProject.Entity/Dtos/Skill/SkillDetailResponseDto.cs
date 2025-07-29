using Core.Entities;

namespace cvProject.Entity.Dtos.Skill
{
    public sealed record SkillDetailResponseDto(
        Guid Id,
        string Title,
        string Icon,
        bool IsProgramLanguageAndTool,
        bool IsActive,
        bool IsDeleted
        ) : IDetailDto;


}
