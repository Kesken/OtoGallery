using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Users.Command.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public DeleteUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(x => x.Id.Equals(request.Id));
            await _userRepository.DeleteAsync(user);

            DeleteUserCommandResponse response = _mapper.Map<DeleteUserCommandResponse>(user);

            return response;

        }
    }
}
