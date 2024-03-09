using BackEnd.Model.Confirm.EFCore;
using BackEnd.DataBase;
using BackEnd.Model.Confirm.Dto;

namespace BackEnd.Model.Confirm;

public class ConfirmBL(ToDoAppContext context)
{
    public ConfirmEFCore EFCore { get; protected set; } = new ConfirmEFCore(context);

    public async Task CreateToDo(ToDoDto dto)
    {
        await EFCore.CreateToDo(dto);
    }

    public async Task UpdateToDo(Guid id,ToDoDto dto)
    {
        await EFCore.UpdateToDo(id,dto);
    }

    public async Task DeleteToDo(Guid id)
    {
        await EFCore.DeleteToDo(id);
    }
}
