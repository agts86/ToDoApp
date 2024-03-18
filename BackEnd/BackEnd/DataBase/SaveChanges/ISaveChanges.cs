using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.SaveChanges;

public interface ISaveChanges
{
    public EntityState EntityState { get; set; }

    public void ChangeMeta(Meta meta);
}
