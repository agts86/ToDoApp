using BackEnd.DataBase.Table;

namespace BackEnd.Model.DropDown.Dto;

public class InitDto(Genre[] genres, Status[] statuses)
{
    public Genre[] Genres { get; set; } = genres;

    public Status[] Statuses { get; set; } = statuses;
}
