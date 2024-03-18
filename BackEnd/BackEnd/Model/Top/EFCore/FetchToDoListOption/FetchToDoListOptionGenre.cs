using BackEnd.Model.Top.Dto;
using BackEnd.DataBase.Table;

namespace BackEnd.Model.Top.EFCore.FetchToDoListOption;

public class FetchToDoListOptionGenre(GetToDoListDto dto) : FetchToDoListOptionBase(dto)
{
    public override IQueryable<ToDo> Filter(IQueryable<ToDo> toDos)
    {
        if(!Dto.Genre.HasValue) return toDos;
        return toDos.Where(x => x.GenreId == Dto.Genre.Value);
    }
}
