using MediatR;

namespace Business.Features.Colors.Command.CreateColor
{
    public class CreateColorCommandRequest : IRequest<CreateColorCommandResponse>
    {
        public string Name { get; set; }
    }
}
