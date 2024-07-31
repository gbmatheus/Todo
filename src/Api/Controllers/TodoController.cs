using Api.Comunnication.Requests.CreateTodo;
using Api.Comunnication.Responses;
using Api.Entities;
using Api.UseCase.Todos.CreateTodo;
using Api.UseCase.Todos.GetTodos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var todos = new GetTodos().Execute();
            return Ok(todos);
        }

        [HttpPost]
        public IActionResult Create([FromBody] RequestCreateTodoJson todo)
        {

            var result = new CreateTodoUseCase().execute(todo);
            var response = new ResponseCreatedTodoJson { Id = result.Id, Name = result.Name };
            return Created(string.Empty, response);
        }

    }
}