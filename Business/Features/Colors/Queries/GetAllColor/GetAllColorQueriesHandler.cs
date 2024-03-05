using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Colors.Queries.GetAllColor
{
    public class GetAllColorQueriesHandler : IRequestHandler<GetAllColorQueriesRequest, ICollection<GetAllColorQueriesResponse>>
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;
        public GetAllColorQueriesHandler(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetAllColorQueriesResponse>> Handle(GetAllColorQueriesRequest request, CancellationToken cancellationToken)
        {
            ICollection<Color> colors = await _colorRepository.GetListAsync();

            ICollection<GetAllColorQueriesResponse> getAllColors = _mapper.Map<ICollection<GetAllColorQueriesResponse>>(colors);

            return getAllColors;
        }
    }
}
