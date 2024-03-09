using BackEnd.DataBase;
using BackEnd.Model.DropDown;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DropDownController(ToDoAppContext context) : ControllerBase
{
    public DropDownBL BL { get; protected set; } = new DropDownBL(context);

    [HttpGet("init")]
    public async Task<IActionResult> GetInit()
    {
        var init = await BL.GetInit();
        return Ok(init);
    }
}
