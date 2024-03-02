using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Brands.Command.CreateBrand;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandResponse>
{
	private readonly IBrandRepository _brandRepository;

	public CreateBrandCommandHandler(IBrandRepository brandRepository)
	{
		_brandRepository = brandRepository;
	}

	public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
	{
		Brand brand = new();
		brand.Name = request.Name;

		await _brandRepository.AddAsync(brand);

		CreateBrandCommandResponse response = new();

		response.Id = brand.Id;
		response.Name = brand.Name;
		response.CreatedDate = brand.CreatedDate;

		return response;

	}
}
