using DataAccess.Abstract;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandResponse>
    {
        private readonly IBrandDal _brandDal;

        public CreateBrandCommandHandler(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            Brand brand = new();
            brand.Name = request.Name;

            await _brandDal.AddAsync(brand);

            CreateBrandCommandResponse response = new();

            response.Id = brand.Id;
            response.Name = brand.Name;
            response.CreatedDate = brand.CreatedDate;

            return response;

        }
    }
}
