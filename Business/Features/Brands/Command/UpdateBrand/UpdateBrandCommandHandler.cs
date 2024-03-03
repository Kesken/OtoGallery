using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Brands.Command.UpdateBrand
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest, UpdateBrandCommandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<UpdateBrandCommandResponse> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate: x => x.Id.Equals(request.Id));
            brand = _mapper.Map(request, brand);

            await _brandRepository.UpdateAsync(brand);

            UpdateBrandCommandResponse response = _mapper.Map<UpdateBrandCommandResponse>(brand);

            return response;
        }
    }
}
