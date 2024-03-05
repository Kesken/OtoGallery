using MediatR;

namespace Business.Features.Cars.Queries.GetAllCars
{
    public class GetAllCarQueriesRequest : IRequest<ICollection<GetAllCarQueriesResponse>>
    {
    }
}
