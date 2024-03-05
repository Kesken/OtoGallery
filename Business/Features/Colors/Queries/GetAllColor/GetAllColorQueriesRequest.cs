using MediatR;

namespace Business.Features.Colors.Queries.GetAllColor
{
    public class GetAllColorQueriesRequest : IRequest<ICollection<GetAllColorQueriesResponse>>
    {
    }
}
