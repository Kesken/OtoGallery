using Business.Features.Brands.Command.CreateBrand;
using Business.Features.Brands.Command.DeleteBrand;
using Business.Features.Brands.Command.UpdateBrand;
using Business.Features.Brands.Queries.GetAllBrand;
using Business.Features.Brands.Queries.GetBrand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OtoGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(CreateBrandCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateBrandCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteBrandCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpGet("getbrand")]
        public async Task<IActionResult> GetBrand([FromQuery] GetBrandQueriesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("getallbrand")]
        public async Task<IActionResult> GetAllBrand([FromQuery] GetAllBrandQueriesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
