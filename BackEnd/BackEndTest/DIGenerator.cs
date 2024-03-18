using System;
using BackEnd.DataBase;
using Microsoft.EntityFrameworkCore;

namespace BackEndTest
{
    public class DIGenerator
    {
        public static ToDoAppContext GetTodoAppContext()
        {
            var options = new DbContextOptionsBuilder<ToDoAppContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new ToDoAppContext(options);
        }
    }
}