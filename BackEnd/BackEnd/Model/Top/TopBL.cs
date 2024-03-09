using BackEnd.Model.Top.EFCore;
using BackEnd.Model.Top.Dto;
using BackEnd.DataBase;

namespace BackEnd.Model.Top;

public class TopBL(ToDoAppContext context)
{
    public TopEFCore EFCore { get; protected set; } = new TopEFCore(context);

    public async Task<GetToDoListReturnDto[]> GetToDoList(GetToDoListDto dto)
    {
        var toDos = await EFCore.FetchToDoList(dto);
        return toDos.Select(x => new GetToDoListReturnDto(x)).ToArray();
    }
}
