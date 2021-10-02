using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskApi.Models;

namespace taskApi.Services
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                id = 1,
                Title = "Get books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                id = 2,
                Title = "Get vegitables",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                id = 3,
                Title = "Water the plans",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };
            todos.Add(todo3);

            return todos;
        }
    }
}
