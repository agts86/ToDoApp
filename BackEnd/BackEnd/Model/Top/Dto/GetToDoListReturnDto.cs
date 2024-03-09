using BackEnd.DataBase.Table;

namespace BackEnd.Model.Top.Dto;

public class GetToDoListReturnDto(ToDo toDo)
{
    public Guid Id { get; set; } = toDo.Id;

    public string Title { get; set; } = toDo.Title;

    public string Genre { get; set; }  = toDo.Genre.Value;

    public DateTime Date { get; set; }  = toDo.Date;

    public string Content { get; set; } = toDo.Content;

    public string Status { get; set; } = toDo.Status.Value;
}
