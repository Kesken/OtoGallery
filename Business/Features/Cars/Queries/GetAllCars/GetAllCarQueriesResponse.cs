namespace Business.Features.Cars.Queries.GetAllCars
{
    public class GetAllCarQueriesResponse
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public List<string> ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
