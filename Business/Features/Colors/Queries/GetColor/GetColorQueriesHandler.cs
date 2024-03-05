using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Colors.Queries.GetColor
{
    public class GetColorQueriesHandler : IRequestHandler<GetColorQueriesRequest, GetColorQueriesResponse>
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public GetColorQueriesHandler(IColorRepository colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }

        public async Task<GetColorQueriesResponse> Handle(GetColorQueriesRequest request, CancellationToken cancellationToken)
        {
            Color? color = await _colorRepository.GetAsync(predicate: x => x.Id.Equals(request.Id), withDeleted: false, cancellationToken: cancellationToken);

            GetColorQueriesResponse response = _mapper.Map<GetColorQueriesResponse>(color);

            return response;
        }
    }
}
