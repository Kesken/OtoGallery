using Business.Features.Colors.Command.CreateColor;
using Business.Features.Colors.Command.DeleteColor;
using Business.Features.Colors.Command.UpdateColor;
using Business.Features.Colors.Queries.GetAllColor;
using Business.Features.Colors.Queries.GetColor;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OtoGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ColorsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(CreateColorCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateColorCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteColorCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpGet("getcolor")]
        public async Task<IActionResult> GetColor([FromQuery] GetColorQueriesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("getallcolor")]
        public async Task<IActionResult> GetAllColor([FromQuery] GetAllColorQueriesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
