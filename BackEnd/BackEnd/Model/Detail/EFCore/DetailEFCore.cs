using BackEnd.DataBase;
using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Model.Detail.EFCore;

public class DetailEFCore(ToDoAppContext context)
{
    public ToDoAppContext Context { get; set; } = context;
  
    public async Task<ToDo> FetchToDo(Guid id)
    {
        return await Context.ToDos.AsNoTracking()
            .Where(x => x.Id == id)
            .SingleOrDefaultAsync();
    }
}
