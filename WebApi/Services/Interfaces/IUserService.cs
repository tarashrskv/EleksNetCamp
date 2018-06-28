﻿using WebApi.Models.DataTransferObjects;
using WebApi.Models.Entities;

namespace WebApi.Services.Interfaces
{
    public interface IUserService : IService<User, UserDto>
    {
    }
}