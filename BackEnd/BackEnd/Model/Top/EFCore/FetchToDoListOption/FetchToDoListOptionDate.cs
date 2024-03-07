using BackEnd.Model.Top.Dto;
using BackEnd.DataBase.Model;
using BackEnd.Extensions;

namespace BackEnd.Model.Top.EFCore.FetchToDoListOption;

public class FetchToDoListOptionDate(GetToDoListDto dto) : FetchToDoListOptionBase(dto)
{
    public override ToDo[] Filter(ToDo[] toDos)
    {
        return toDos.Where(x => x.Date.Equal(Dto.Date)).ToArray();
    }
}
