namespace MyFirstApi.Controllers;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DeviceController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Laptop.");
    }
}