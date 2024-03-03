using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Brands.Queries.GetBrand
{
    public class GetBrandQueriesHandler : IRequestHandler<GetBrandQueriesRequest, GetBrandQueriesResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetBrandQueriesHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<GetBrandQueriesResponse> Handle(GetBrandQueriesRequest request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate: x => x.Id.Equals(request.Id), withDeleted: false, cancellationToken: cancellationToken);

            GetBrandQueriesResponse response = _mapper.Map<GetBrandQueriesResponse>(brand);

            return response;
        }
    }
}
