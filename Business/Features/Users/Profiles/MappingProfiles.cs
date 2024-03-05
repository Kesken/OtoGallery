using AutoMapper;
using Business.Features.Users.Command.CreateUser;
using Business.Features.Users.Command.DeleteUser;
using Business.Features.Users.Command.UpdateUser;
using Business.Features.Users.Queries.GetAllUsers;
using Business.Features.Users.Queries.GetUser;
using Entities.Concretes;

namespace Business.Features.Users.Profiles
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<User, CreateUserCommandRequest>().ReverseMap();
            CreateMap<User, CreateUserCommandResponse>().ReverseMap();

            CreateMap<User, UpdateUserCommandRequest>().ReverseMap();
            CreateMap<User, UpdateUserCommandResponse>().ReverseMap();

            CreateMap<User, DeleteUserCommandRequest>().ReverseMap();
            CreateMap<User, DeleteUserCommandResponse>().ReverseMap();

            CreateMap<User, GetUserQueriesRequest>().ReverseMap();
            CreateMap<User, GetUserQueriesResponse>().ReverseMap();

            CreateMap<User, GetAllUsersQueriesRequest>().ReverseMap();
            CreateMap<User, GetAllUsersQueriesResponse>().ReverseMap();
        }

    }
}
