namespace Business.Features.Colors.Command.DeleteColor
{
    public class DeleteColorCommandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}
