using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.SaveChanges;

public class SaveChangesModify(EntityState entityState) : SaveChangesBase(entityState)
{
    public override void ChangeMeta(Meta meta)
    {
        meta.UpdatedAt = DateTime.Now;
    }
}
