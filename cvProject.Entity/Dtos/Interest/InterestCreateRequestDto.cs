using Core.Entities;

namespace cvProject.Entity.Dtos.Interest
{
    public sealed record InterestCreateRequestDto(
        string Description,
        byte Order
        ) : ICreateDto;


}
