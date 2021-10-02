using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskApi.Services;
using TaskApi.Services;

namespace taskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
       
        private readonly TodoService _todoService;

        public TodosController(ItodoRepository repository)
        {

            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos();

            if (id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.id == id).ToList();

            return Ok(myTodos);
        }


    }
}
