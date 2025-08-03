namespace MyFirstApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[Route("sodras/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Pedro Sodré";

    [HttpGet("healthy")]
    public IActionResult Healthy()
    {
        return Ok("It's working!");
    }
    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}