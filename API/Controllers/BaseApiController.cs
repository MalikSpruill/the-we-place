using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // "controller" is a placeholder for what the true value name will be
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator = null!;

        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;
        // protected IMediator? Mediator => (_mediator == null) ? _mediator = HttpContext.RequestServices.GetService<IMediator>()! : _mediator;
    }
}