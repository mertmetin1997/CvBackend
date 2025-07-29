﻿using Core.Entities;

namespace cvProject.Entity.Dtos.SocialAccount
{
    public sealed record SocialAccountCreateRequestDto(
        string Name,
        string WebUrl,
        string UserName,
        string Icon
        ) : ICreateDto;


}
