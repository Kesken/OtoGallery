using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Colors.Command.CreateColor
{
    public class CreateColorCommandHandler : IRequestHandler<CreateColorCommandRequest, CreateColorCommandResponse>
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public CreateColorCommandHandler(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }

        public async Task<CreateColorCommandResponse> Handle(CreateColorCommandRequest request, CancellationToken cancellationToken)
        {
            Color color = _mapper.Map<Color>(request);
            await _colorRepository.AddAsync(color);

            CreateColorCommandResponse response = _mapper.Map<CreateColorCommandResponse>(color);

            return response;
        }
    }
}
