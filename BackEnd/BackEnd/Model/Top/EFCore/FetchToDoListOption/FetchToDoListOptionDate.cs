using BackEnd.Model.Top.Dto;
using BackEnd.DataBase.Table;
using BackEnd.Extensions;

namespace BackEnd.Model.Top.EFCore.FetchToDoListOption;

public class FetchToDoListOptionDate(GetToDoListDto dto) : FetchToDoListOptionBase(dto)
{
    public override IQueryable<ToDo> Filter(IQueryable<ToDo> toDos)
    {
        if(!Dto.Date.HasValue) return toDos;
        return toDos.Where(x => x.Date.Equal(Dto.Date));
    }
}
