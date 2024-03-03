using AutoMapper;
using Business.Features.Brands.Command.CreateBrand;
using Business.Features.Brands.Command.DeleteBrand;
using Business.Features.Brands.Command.UpdateBrand;
using Business.Features.Brands.Queries.GetAllBrand;
using Business.Features.Brands.Queries.GetBrand;
using Entities.Concretes;

namespace Business.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreateBrandCommandRequest>().ReverseMap();
            CreateMap<Brand, CreateBrandCommandResponse>().ReverseMap();

            CreateMap<Brand, UpdateBrandCommandRequest>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommandResponse>().ReverseMap();

            CreateMap<Brand, DeleteBrandCommandRequest>().ReverseMap();
            CreateMap<Brand, DeleteBrandCommandResponse>().ReverseMap();

            CreateMap<Brand, GetBrandQueriesRequest>().ReverseMap();
            CreateMap<Brand, GetBrandQueriesResponse>().ReverseMap();

            CreateMap<Brand, GetAllBrandQueriesRequest>().ReverseMap();
            CreateMap<Brand, GetAllBrandQueriesResponse>().ReverseMap();

        }
    }
}
