using MediatR;

namespace Business.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueriesRequest : IRequest<ICollection<GetAllUsersQueriesResponse>>
    {

    }
}
