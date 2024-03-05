using MediatR;

namespace Business.Features.Colors.Command.DeleteColor
{
    public class DeleteColorCommandRequest : IRequest<DeleteColorCommandResponse>
    {
        public int Id { get; set; }
    }
}
