using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Brands.Queries.GetAllBrand
{
    public class GetAllBrandQueriesHandler : IRequestHandler<GetAllBrandQueriesRequest, ICollection<GetAllBrandQueriesResponse>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        public GetAllBrandQueriesHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetAllBrandQueriesResponse>> Handle(GetAllBrandQueriesRequest request, CancellationToken cancellationToken)
        {
            ICollection<Brand> brands = await _brandRepository.GetListAsync();

            ICollection<GetAllBrandQueriesResponse> getAllBrands = _mapper.Map<ICollection<GetAllBrandQueriesResponse>>(brands);

            return getAllBrands;
        }
    }
}
