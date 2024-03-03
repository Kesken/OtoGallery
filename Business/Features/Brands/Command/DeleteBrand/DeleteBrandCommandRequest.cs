using MediatR;

namespace Business.Features.Brands.Command.DeleteBrand
{
    public class DeleteBrandCommandRequest : IRequest<DeleteBrandCommandResponse>
    {
        public int Id { get; set; }
    }
}
