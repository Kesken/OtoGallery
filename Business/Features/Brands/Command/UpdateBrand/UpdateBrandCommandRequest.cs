using MediatR;

namespace Business.Features.Brands.Command.UpdateBrand
{
    public class UpdateBrandCommandRequest : IRequest<UpdateBrandCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
