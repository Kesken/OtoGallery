using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Brands.Command.CreateBrand;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandResponse>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;
    public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        Brand brand = _mapper.Map<Brand>(request);
        await _brandRepository.AddAsync(brand);

        CreateBrandCommandResponse response = _mapper.Map<CreateBrandCommandResponse>(brand);

        return response;

    }
}
