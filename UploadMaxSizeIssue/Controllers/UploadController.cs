using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace UploadMaxSizeIssue.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class UploadController : ControllerBase
{
    [HttpPost("with_controller")]
    public IActionResult Upload(IFormFile file) => NoContent();
}
