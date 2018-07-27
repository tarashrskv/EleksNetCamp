﻿using AutoMapper;
using BusinessLogicLayer.Mappings.Resolvers;
using Models.DataTransferObjects;
using Models.Entities;

namespace BusinessLogicLayer.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, User>().ForMember(user => user.Login, dto => dto.MapFrom(from => from.Login))
                                      .ForMember(user => user.PasswordHash, dto => dto.ResolveUsing<PasswordToHashResolver>());

            CreateMap<GameDto, Game>().ForMember(game => game.Title, dto => dto.MapFrom(from => from.Title))
                                      .ForMember(game => game.About, dto => dto.MapFrom(from => from.About))
                                      .ForMember(game => game.ImageSrc, dto => dto.MapFrom(from => from.ImageSrc));

            CreateMap<ResultDto, Result>().ForMember(result => result.UserId, dto => dto.MapFrom(from => from.UserId))
                                          .ForMember(result => result.GameId, dto => dto.MapFrom(from => from.GameId))
                                          .ForMember(result => result.Score, dto => dto.MapFrom(from => from.Score));
        }
    }
}