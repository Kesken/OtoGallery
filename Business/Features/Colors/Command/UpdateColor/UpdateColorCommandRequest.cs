using MediatR;

namespace Business.Features.Colors.Command.UpdateColor
{
    public class UpdateColorCommandRequest : IRequest<UpdateColorCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
