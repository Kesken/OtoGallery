using MediatR;

namespace Business.Features.Cars.Command.DeleteCar
{
    public class DeleteCarCommandRequest : IRequest<DeleteCarCommandResponse>
    {
        public int Id { get; set; }
    }
}

