using System.Reflection;
using BackEnd.DataBase;
using BackEnd.DataBase.Model;
using BackEnd.Model.Top.Dto;
using Microsoft.EntityFrameworkCore;
using BackEnd.Model.Top.EFCore.FetchToDoListOption;

namespace BackEnd.Model.Top.EFCore;

public class TopEFCore(ToDoAppContext context)
{
    public ToDoAppContext Context { get; set; } = context;
  
    public async Task<Genre[]> FetchGenres()
    {
        return await Context.Genres.AsNoTracking().ToArrayAsync();
    }

    public async Task<Status[]> FetchStatuses()
    {
        return await Context.Statuses.AsNoTracking().ToArrayAsync();
    }

    public async Task<ToDo[]> FetchToDoList(GetToDoListDto dto)
    {
        var todo = await Context.ToDos.AsNoTracking()
            .Include(x => x.Genre)
            .Include(x => x.Status)
            .Where(x => x.GenreId == dto.Genre)
            .Where(x => x.StatusId == dto.Status)
            .ToArrayAsync();
        var FilterOptions = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => typeof(FetchToDoListOptionBase).IsAssignableFrom(x) && !x.IsAbstract)
            .Select(x => (FetchToDoListOptionBase)Activator.CreateInstance(x, dto))
            .ToArray();
        foreach (var option in FilterOptions)
        {
            todo = option.Filter(todo);
        }
        return todo;
    }
}
