using AutoMapper;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Dto.Comments;
using System.Collections.Generic;

namespace StopBeingJerk.ApplicationLogic
{
    public static class MapperConfigurator
    {
        public static IMapper mapper { get; }
        static MapperConfigurator()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CarBrand, CarBrandDto>().ReverseMap();

                cfg.CreateMap<CarModel, CarModelDto>().ReverseMap();

                cfg.CreateMap<CarInfoCard, CarInfoCardDto>().ReverseMap();

                cfg.CreateMap<Color, ColorDto>().ReverseMap();

                cfg.CreateMap<RegistrationNumber, RegistrationNumberDto>().ReverseMap();

                cfg.CreateMap<Photo, PhotoDto>().ReverseMap();

                cfg.CreateMap<PhotoInfoCard, PhotoInfoCardDto>().ReverseMap();

                cfg.CreateMap<CommentTopicType, CommentTopicTypeDto>().ReverseMap();

                cfg.CreateMap<CommentTopic, CommentTopicTypeDto>().ReverseMap();

                cfg.CreateMap<Comment, CommentDto>().ReverseMap();
            });
            mapper = config.CreateMapper();
        }
    }
}
