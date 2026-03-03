using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PolicyService.Implementation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PolicyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PolicyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetPolicyByIdQuery(id));
            return Ok(result);
        }
    }
}