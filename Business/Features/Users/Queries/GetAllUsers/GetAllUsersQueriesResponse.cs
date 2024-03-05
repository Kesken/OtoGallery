﻿namespace Business.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueriesResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
