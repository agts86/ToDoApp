using BackEnd.DataBase;
using BackEnd.Model.Detail;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DetailController(ToDoAppContext context) : ControllerBase
{
    public DetailBL BL { get; protected set; } = new DetailBL(context);

    [HttpGet("{id}")]
    public async Task<IActionResult> GetToDo([FromRoute] Guid id)
    {
        var toDo = await BL.GetToDo(id);
        return Ok(toDo);
    }
}
