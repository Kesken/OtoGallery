using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Users.Queries.GetUser
{
    public class GetUserQueriesHandler : IRequestHandler<GetUserQueriesRequest, GetUserQueriesResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserQueriesHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetUserQueriesResponse> Handle(GetUserQueriesRequest request, CancellationToken cancellationToken)
        {

            User? user = await _userRepository.GetAsync(x => x.Id.Equals(request.Id));

            GetUserQueriesResponse response = _mapper.Map<GetUserQueriesResponse>(user);

            return response;


        }
    }
}
