namespace Business.Features.Users.Command.DeleteUser
{
    public class DeleteUserCommandResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
