using BackEnd.Model.Top.Dto;
using BackEnd.DataBase.Table;

namespace BackEnd.Model.Top.EFCore.FetchToDoListOption;

public class FetchToDoListOptionStatus(GetToDoListDto dto) : FetchToDoListOptionBase(dto)
{
    public override IQueryable<ToDo> Filter(IQueryable<ToDo> toDos)
    {
        if(!Dto.Status.HasValue) return toDos;
        return toDos.Where(x => x.StatusId == Dto.Status.Value);
    }
}
