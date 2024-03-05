namespace Business.Features.Cars.Command.UpdateCar
{
    public class UpdateCarCommandResponse
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public List<string> ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
