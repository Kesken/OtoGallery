namespace Business.Features.Brands.Command.DeleteBrand
{
    public class DeleteBrandCommandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
