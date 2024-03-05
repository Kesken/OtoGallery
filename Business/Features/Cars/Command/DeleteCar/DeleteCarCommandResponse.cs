namespace Business.Features.Cars.Command.DeleteCar
{
    public class DeleteCarCommandResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
