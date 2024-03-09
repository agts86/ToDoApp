using System;
using System.Collections.Generic;
using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.SaveChanges;

public abstract class SaveChangesBase(EntityState entityState)
{
    public EntityState EntityState { get; set; } = entityState;

    public abstract void ChangeMeta(Meta meta);
}
