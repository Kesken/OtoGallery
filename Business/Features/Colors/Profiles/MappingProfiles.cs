using AutoMapper;
using Business.Features.Colors.Command.CreateColor;
using Business.Features.Colors.Command.DeleteColor;
using Business.Features.Colors.Command.UpdateColor;
using Business.Features.Colors.Queries.GetAllColor;
using Business.Features.Colors.Queries.GetColor;
using Entities.Concretes;

namespace Business.Features.Colors.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Color, CreateColorCommandRequest>().ReverseMap();
            CreateMap<Color, CreateColorCommandResponse>().ReverseMap();

            CreateMap<Color, UpdateColorCommandRequest>().ReverseMap();
            CreateMap<Color, UpdateColorCommandResponse>().ReverseMap();

            CreateMap<Color, DeleteColorCommandRequest>().ReverseMap();
            CreateMap<Color, DeleteColorCommandResponse>().ReverseMap();

            CreateMap<Color, GetColorQueriesRequest>().ReverseMap();
            CreateMap<Color, GetColorQueriesResponse>().ReverseMap();

            CreateMap<Color, GetAllColorQueriesRequest>().ReverseMap();
            CreateMap<Color, GetAllColorQueriesResponse>().ReverseMap();

        }
    }
}
