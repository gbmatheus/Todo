using Api.Comunnication.Requests.Todo;
using Api.Comunnication.Responses;
using Api.Comunnication.Responses.Error;
using Api.Comunnication.Responses.Todo;
using Api.UseCase.Todos.CreateTodo;
using Api.UseCase.Todos.DeleteTodo;
using Api.UseCase.Todos.GetTodoById;
using Api.UseCase.Todos.GetTodos;
using Api.UseCase.Todos.UpdateTodo;
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
            try
            {
                var useCase = new CreateTodoUseCase();
                var response = useCase.execute(todo);
                return Created(string.Empty, response);
            } catch (BadHttpRequestException ex)
            {
                var response = new ResponseErrorJson(ex.Message);
                return BadRequest(response);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTodo([FromRoute] int id)
        {
            var result = new GetTodoByIdUseCase().execute(id);

            if(result == null)
                    return NotFound();
            var response = new ReponseGetTodoJson()
            {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description,
                Deadline = result.Deadline,
                Status = result.Status,
                Priority = result.Priority,
            };
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateTodoJson todo)
        {
            var result = new UpdateTodoUseCase().execute(id, todo);
            if (!result)
                return NotFound(id);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = new DeleteTodoUseCase().execute(id);
            if (!result)
                return NotFound(id);
            return NoContent();
        }

    }
}