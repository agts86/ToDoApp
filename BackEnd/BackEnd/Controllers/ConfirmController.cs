using BackEnd.DataBase;
using BackEnd.Model;
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
        try
        {
            await BL.UpdateToDo(id,dto);
            return Ok();
        }
        catch (NotFoundException)
        {
            return NotFound(id);
        }      
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteToDo([FromRoute] Guid id)
    {
        try
        {
            await BL.DeleteToDo(id);
            return Ok();
        }
        catch (NotFoundException)
        {
            return NotFound(id);
        }
    }
}
