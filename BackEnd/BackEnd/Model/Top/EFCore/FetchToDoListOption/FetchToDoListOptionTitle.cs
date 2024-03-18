using BackEnd.Model.Top.Dto;
using BackEnd.DataBase.Table;

namespace BackEnd.Model.Top.EFCore.FetchToDoListOption;

public class FetchToDoListOptionTitle(GetToDoListDto dto) : FetchToDoListOptionBase(dto)
{
    public override IQueryable<ToDo> Filter(IQueryable<ToDo> toDos)
    {
        if(Dto.Title == null) return toDos;
        return toDos.Where(x => x.Title == Dto.Title);
    }
}
