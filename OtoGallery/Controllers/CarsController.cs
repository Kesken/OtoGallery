using Business.Features.Cars.Command.CreateCar;
using Business.Features.Cars.Command.DeleteCar;
using Business.Features.Cars.Command.UpdateCar;
using Business.Features.Cars.Queries.GetAllCars;
using Business.Features.Cars.Queries.GetCar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OtoGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(CreateCarCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCarCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCarCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("getcar")]
        public async Task<IActionResult> GetCar([FromQuery] GetCarQueriesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("getallcar")]
        public async Task<IActionResult> GetAllCar([FromQuery] GetAllCarQueriesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
