using Api.Comunnication.Responses.Todo;
using Api.Domain.Entities;
using Api.Repositories;

namespace Api.UseCase.Todos.GetTodoById
{
    public class GetTodoByIdUseCase
    {
        public ReponseGetTodoJson execute(int id)
        {
            var repository = new TodoDbContext();
            var todo = repository.Todos.FirstOrDefault(t => t.Id == id) as Todo;

            if (todo == null) return null;

            var response = new ReponseGetTodoJson()
            {
                Id = id,
                Name = todo.Name,
                Description = todo.Description,
                Priority = todo.Priority,
                Status = todo.Status,
                Deadline = todo.Deadline,
            };
            return response;
        }
    }
}
