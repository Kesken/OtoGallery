using MediatR;

namespace Business.Features.Cars.Queries.GetCar
{
    public class GetCarQueriesRequest : IRequest<GetCarQueriesResponse>
    {
        public int Id { get; set; }
    }
}
