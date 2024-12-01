using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ApiBaseController : ControllerBase
{
    private ISender? _mediator;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

}