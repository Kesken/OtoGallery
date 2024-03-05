using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Colors.Command.DeleteColor
{
    public class DeleteColorCommandHandler : IRequestHandler<DeleteColorCommandRequest, DeleteColorCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IColorRepository _colorRepository;

        public DeleteColorCommandHandler(IMapper mapper, IColorRepository colorRepository)
        {
            _mapper = mapper;
            _colorRepository = colorRepository;
        }

        public async Task<DeleteColorCommandResponse> Handle(DeleteColorCommandRequest request, CancellationToken cancellationToken)
        {
            Color? color = await _colorRepository.GetAsync(predicate: x => x.Id.Equals(request.Id));

            await _colorRepository.DeleteAsync(color);

            DeleteColorCommandResponse response = _mapper.Map<DeleteColorCommandResponse>(color);

            return response;
        }
    }
}
