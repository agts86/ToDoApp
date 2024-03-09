using BackEnd.Model.Detail.EFCore;
using BackEnd.DataBase;
using BackEnd.DataBase.Table;

namespace BackEnd.Model.Detail;

public class DetailBL(ToDoAppContext context)
{
    public DetailEFCore EFCore { get; protected set; } = new DetailEFCore(context);

    public async Task<ToDo> GetToDo(Guid id)
    {
        return await EFCore.FetchToDo(id);
    }
}
