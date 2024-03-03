using MediatR;

namespace Business.Features.Brands.Queries.GetBrand
{
    public class GetBrandQueriesRequest : IRequest<GetBrandQueriesResponse>
    {
        public int Id { get; set; }
    }
}
