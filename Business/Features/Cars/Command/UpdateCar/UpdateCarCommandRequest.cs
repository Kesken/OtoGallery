using MediatR;

namespace Business.Features.Cars.Command.UpdateCar
{
    public class UpdateCarCommandRequest : IRequest<UpdateCarCommandResponse>
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public List<int> ColorIds { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
