﻿using Core.Entities;

namespace cvProject.Entity.Dtos.Contact
{
    public sealed record ContactCreateRequestDto(
        string Address,
        string City,
        string Town,
        string Phone,
        string Email
        ) : ICreateDto;

}
