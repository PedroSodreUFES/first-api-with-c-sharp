namespace MyFirstApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = this.GetCustomKey();

        return Ok(key);
    }
}