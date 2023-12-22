using MediatR;
using Microsoft.AspNetCore.Mvc;
using YoutubeApi.Application.Features.Products.Queries.GetAllProducts;

namespace Youtube.API.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class ProducController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProducController(IMediator mediator)
        {

            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }
    }
}
