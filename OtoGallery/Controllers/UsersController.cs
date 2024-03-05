using Business.Features.Users.Command.CreateUser;
using Business.Features.Users.Command.DeleteUser;
using Business.Features.Users.Command.UpdateUser;
using Business.Features.Users.Queries.GetAllUsers;
using Business.Features.Users.Queries.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OtoGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateUserCommandRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserCommandRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteUserCommandRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }
        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] GetUserQueriesRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] GetAllUsersQueriesRequest request)
        {
            var product = await _mediator.Send(request);
            return Ok(product);
        }
    }
}
