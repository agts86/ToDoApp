using BackEnd.DataBase;
using BackEnd.Model.Top.Dto;
using BackEnd.Model.Top;
using Microsoft.AspNetCore.Mvc;


namespace BackEnd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TopController(ToDoAppContext context) : ControllerBase
{
    public TopBL BL { get; protected set; } = new TopBL(context);

    [HttpGet("init")]
    public async Task<IActionResult> GetInit()
    {
        var init = await BL.GetInit();
        return Ok(init);
    }


    [HttpGet("Select")]
    public async Task<IActionResult> GetToDoList([FromQuery] GetToDoListDto dto)
    {
        var toDos = await BL.GetToDoList(dto);
        return Ok(toDos);
    }
}
