using BackEnd.DataBase;
using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;
using BackEnd.Model.Confirm.Dto;

namespace BackEnd.Model.Confirm.EFCore;

public class ConfirmEFCore(ToDoAppContext context)
{
    public ToDoAppContext Context { get; set; } = context;
  
    private async Task<ToDo> FetchToDo(Guid id)
    {
        return await Context.ToDos
            .Where(x => x.Id == id)
            .SingleOrDefaultAsync();
    }

    public async Task CreateToDo(ToDoDto dto)
    {
        var todo = new ToDo
        {
            Id = new Guid(),
            Title = dto.Title,
            GenreId = dto.Genre,
            Date = dto.Date,
            Content = dto.Content,
            StatusId = dto.Status,
        };
        Context.ToDos.Add(todo);
        await Context.SaveChangesAsync();
    }

    public async Task UpdateToDo(Guid id,ToDoDto dto)
    {
        var todo = await FetchToDo(id) ?? throw new NotFoundException();
        todo.Title = dto.Title;
        todo.GenreId = dto.Genre;
        todo.Date = dto.Date;
        todo.Content = dto.Content;
        todo.StatusId = dto.Status;
        Context.ToDos.Update(todo);
        await Context.SaveChangesAsync();
    }

    public async Task DeleteToDo(Guid id)
    {
        var todo = await FetchToDo(id) ?? throw new NotFoundException();
        Context.ToDos.Remove(todo);
        await Context.SaveChangesAsync();
    }
}
