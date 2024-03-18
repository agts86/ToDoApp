using BackEnd.DataBase;
using BackEnd.DataBase.Table;
using BackEnd.Model.Top.Dto;
using Microsoft.EntityFrameworkCore;
using BackEnd.Model.Top.EFCore.FetchToDoListOption;
using BackEnd.Util;

namespace BackEnd.Model.Top.EFCore;

public class TopEFCore(ToDoAppContext context)
{
    public ToDoAppContext Context { get; set; } = context;

    public async Task<ToDo[]> FetchToDoList(GetToDoListDto dto)
    {
        var todo = Context.ToDos.AsNoTracking();

        var FilterOptions = Polymorphism.CreatePolymorphismArray<FetchToDoListOptionBase>(dto);
            
        foreach (var option in FilterOptions)
        {
            todo = option.Filter(todo);
        }

        return await todo
            .Include(x => x.Genre)
            .Include(x => x.Status)
            .ToArrayAsync();
    }
}
