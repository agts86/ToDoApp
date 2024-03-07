using BackEnd.DataBase.Model;

namespace BackEnd.Model.Top.Dto;

public class InitDto
{
    public Genre[] Genres { get; set; }

    public Status[] Statuses { get; set; }

    public InitDto(Genre[] genres, Status[] statuses)
    {
        Genres = genres;
        Statuses = statuses;
    }
}
