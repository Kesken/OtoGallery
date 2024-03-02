using MediatR;

namespace Business.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandRequest : IRequest<CreateBrandCommandResponse>
    {
        public string Name { get; set; }
    }
}
