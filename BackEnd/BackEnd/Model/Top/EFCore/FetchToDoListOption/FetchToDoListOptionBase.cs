using BackEnd.Model.Top.Dto;
using BackEnd.DataBase.Table;

namespace BackEnd.Model.Top.EFCore.FetchToDoListOption;

public abstract class FetchToDoListOptionBase(GetToDoListDto dto)
{
    public GetToDoListDto Dto { get; set; } = dto ?? throw new ArgumentNullException(nameof(dto));

    public abstract IQueryable<ToDo> Filter(IQueryable<ToDo> toDos);
}
