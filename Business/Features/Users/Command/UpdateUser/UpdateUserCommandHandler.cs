using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Users.Command.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(x => x.Id.Equals(request.Id));

            user = _mapper.Map(request, user);

            await _userRepository.UpdateAsync(user);

            UpdateUserCommandResponse response = _mapper.Map<UpdateUserCommandResponse>(user);

            return response;

        }
    }
}
