using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueriesHandler : IRequestHandler<GetAllUsersQueriesRequest, ICollection<GetAllUsersQueriesResponse>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUsersQueriesHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetAllUsersQueriesResponse>> Handle(GetAllUsersQueriesRequest request, CancellationToken cancellationToken)
        {
            ICollection<User> users = await _userRepository.GetListAsync();

            ICollection<GetAllUsersQueriesResponse> responses = _mapper.Map<ICollection<GetAllUsersQueriesResponse>>(users);

            return responses;
        }
    }
}
