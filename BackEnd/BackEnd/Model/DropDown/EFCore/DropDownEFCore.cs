using BackEnd.DataBase;
using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Model.DropDown.EFCore;

public class DropDownEFCore(ToDoAppContext context)
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
}
