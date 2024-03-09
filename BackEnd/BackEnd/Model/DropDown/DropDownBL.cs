using BackEnd.Model.DropDown.EFCore;
using BackEnd.Model.DropDown.Dto;
using BackEnd.DataBase;

namespace BackEnd.Model.DropDown;

public class DropDownBL(ToDoAppContext context)
{
    public DropDownEFCore EFCore { get; protected set; } = new DropDownEFCore(context);

    public async Task<InitDto> GetInit()
    {
        var genre = await EFCore.FetchGenres();
        var status = await EFCore.FetchStatuses();
        return new InitDto(genre, status);
    }
}
