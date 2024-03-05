using MediatR;

namespace Business.Features.Users.Command.DeleteUser
{
    public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
    {
        public int Id { get; set; }
    }
}
