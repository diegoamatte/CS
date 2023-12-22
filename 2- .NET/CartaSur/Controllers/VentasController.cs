using CartaSur.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CartaSur.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private IMediator _mediator;

        public VentasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetFechaMaximasVentasAsync(CancellationToken cancellationToken)
        {
            var fechaMaximasVentas = await _mediator.Send(new GetFechaMaxVentasQuery(), cancellationToken);
            return Ok(fechaMaximasVentas);
        }
    }
}
