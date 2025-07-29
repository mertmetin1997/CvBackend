using Core.Entities;

namespace cvProject.Entity.Dtos.Language
{
    public sealed record LanguageCreateRequestDto(
        string Name,
        byte Level
        ) : ICreateDto;


}
