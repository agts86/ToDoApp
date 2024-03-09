using BackEnd.Model.Top.Dto;
using BackEnd.DataBase.Table;

namespace BackEnd.Model.Top.EFCore.FetchToDoListOption;

public class FetchToDoListOptionTitle(GetToDoListDto dto) : FetchToDoListOptionBase(dto)
{
    public override ToDo[] Filter(ToDo[] toDos)
    {
        if(Dto.Title == null) return toDos;
        return toDos.Where(x => x.Title == Dto.Title).ToArray();
    }
}
