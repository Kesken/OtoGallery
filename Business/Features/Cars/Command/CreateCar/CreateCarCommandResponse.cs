namespace Business.Features.Cars.Command.CreateCar
{
    public class CreateCarCommandResponse
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public List<string> ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
