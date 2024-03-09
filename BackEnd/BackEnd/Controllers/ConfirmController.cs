using BackEnd.DataBase;
using BackEnd.Model.Confirm.Dto;
using BackEnd.Model.Confirm;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConfirmController(ToDoAppContext context) : ControllerBase
{
    public ConfirmBL BL { get; protected set; } = new ConfirmBL(context);

    [HttpPost("")]
    public async Task<IActionResult> CreateToDo([FromBody] ToDoDto dto)
    {
        await BL.CreateToDo(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateToDo([FromRoute] Guid id,[FromBody] ToDoDto dto)
    {
        await BL.UpdateToDo(id,dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteToDo([FromRoute] Guid id)
    {
        await BL.DeleteToDo(id);
        return Ok();
    }
}
