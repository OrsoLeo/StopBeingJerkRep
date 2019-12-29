using AutoMapper;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Dto.Comments;

namespace StopBeingJerk.Mapper
{
    public class CarsMapper : Profile
    {
        public CarsMapper()
        {
            CreateMap<CarBrand, CarBrandDto>().ReverseMap();

            CreateMap<CarModel, CarModelDto>().ReverseMap();

            CreateMap<CarInfoCard, CarInfoCardDto>().ReverseMap();

            CreateMap<RegistrationNumber, RegistrationNumberDto>().ReverseMap();

            CreateMap<Color, ColorDto>().ReverseMap();
        }
    }
}
