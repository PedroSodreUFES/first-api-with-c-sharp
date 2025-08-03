using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers;

public class UserController : MyFirstApiBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)] // swagger mostrando tipo da resposta e 200
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] // swagger mostrando 400 se der ruim
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 22,
            Name = "Sodras"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)] // swagger mostrando 201
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        // return Created(); Created sem parametro retorna 204

        var response = new ResponseRegisteredUserJson
        {
            Id = 1,
            Name = request.Name,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [Route("{userId}")]
    public IActionResult Update([FromBody] RequestUpdateUserJson request, [FromRoute] int userId)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [Route("{userId}")]
    public IActionResult Delete([FromRoute] int userId)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new User() { Id = 1, Name = "Sodré", Age = 22},
            new User { Id = 2, Name = "Letícia", Age = 21}
        };

        var key = this.GetCustomKey();

        return Ok(key);
    }

    [HttpPut("change-password/")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    // se quisesse um id seria [Route("change-password/{userId}")] no lugar do HttpPut
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request /*, [FromRoute] int userId */)
    {
        return NoContent();
    }
}