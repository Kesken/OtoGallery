using MediatR;

namespace Business.Features.Cars.Command.CreateCar
{
    public class CreateCarCommandRequest : IRequest<CreateCarCommandResponse>
    {
        public int BrandId { get; set; }
        public List<int> ColorIds { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
    }
}
