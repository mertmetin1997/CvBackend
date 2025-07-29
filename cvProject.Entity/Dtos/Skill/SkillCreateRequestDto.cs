using Core.Entities;

namespace cvProject.Entity.Dtos.Skill
{
    public sealed record SkillCreateRequestDto(
        string Title,
        string Icon,
        bool IsProgramLanguageAndTool
        ) : ICreateDto;


}
