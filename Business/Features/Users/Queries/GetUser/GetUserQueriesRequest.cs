using MediatR;

namespace Business.Features.Users.Queries.GetUser
{
    public class GetUserQueriesRequest : IRequest<GetUserQueriesResponse>
    {
        public int Id { get; set; }
    }
}
