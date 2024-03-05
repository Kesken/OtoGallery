using MediatR;

namespace Business.Features.Colors.Queries.GetColor
{
    public class GetColorQueriesRequest : IRequest<GetColorQueriesResponse>
    {
        public int Id { get; set; }

    }
}
