using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Colors.Command.UpdateColor
{
    public class UpdateColorCommandHandler : IRequestHandler<UpdateColorCommandRequest, UpdateColorCommandResponse>
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public UpdateColorCommandHandler(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }
        public async Task<UpdateColorCommandResponse> Handle(UpdateColorCommandRequest request, CancellationToken cancellationToken)
        {
            Color? color = await _colorRepository.GetAsync(predicate: x => x.Id.Equals(request.Id));
            color = _mapper.Map(request, color);

            await _colorRepository.UpdateAsync(color);

            UpdateColorCommandResponse response = _mapper.Map<UpdateColorCommandResponse>(color);

            return response;
        }
    }
}
