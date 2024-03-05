using AutoMapper;
using Business.Features.Cars.Command.CreateCar;
using Business.Features.Cars.Command.DeleteCar;
using Business.Features.Cars.Command.UpdateCar;
using Business.Features.Cars.Queries.GetAllCars;
using Business.Features.Cars.Queries.GetCar;
using Entities.Concretes;

namespace Business.Features.Cars.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, CreateCarCommandRequest>().ReverseMap();
            CreateMap<Car, CreateCarCommandResponse>().ReverseMap();


            CreateMap<Car, UpdateCarCommandRequest>().ReverseMap();
            CreateMap<Car, UpdateCarCommandResponse>().ReverseMap();

            CreateMap<Car, DeleteCarCommandRequest>().ReverseMap();
            CreateMap<Car, DeleteCarCommandResponse>().ReverseMap();

            CreateMap<Car, GetCarQueriesRequest>().ReverseMap();

            CreateMap<Car, GetCarQueriesResponse>()
               .ForMember(destinationMember: x => x.BrandName, memberOptions: x => x.MapFrom(x => x.Brand.Name))
               .ForMember(destinationMember: x => x.ColorName, memberOptions: x => x.MapFrom(x => x.CarColors.Select(x => x.Color.Name)))
               .ReverseMap();

            CreateMap<Car, GetAllCarQueriesRequest>().ReverseMap();
            CreateMap<Car, GetAllCarQueriesResponse>()
                .ForMember(destinationMember: x => x.BrandName, memberOptions: x => x.MapFrom(x => x.Brand.Name))
                .ForMember(destinationMember: x => x.ColorName, memberOptions: x => x.MapFrom(x => x.CarColors.Select(x => x.Color.Name)))
                .ReverseMap();

        }
    }
}
