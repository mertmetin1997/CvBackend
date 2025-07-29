using Core.Entities;

namespace cvProject.Entity.Dtos.About
{
    public sealed record AboutCreateRequestDto(
        string Description,
        byte Order
        ) : ICreateDto;
}
