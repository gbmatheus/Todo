using Api.Comunnication.Requests.CreateTodo;
using Api.Entities;
using Api.Repositories;

namespace Api.UseCase.Todos.CreateTodo
{
    public class CreateTodoUseCase
    {
        public Todo execute(RequestCreateTodoJson todo)
        {
            var repository = new TodoDbContext();

            repository.Add(new Todo
            {
                Name = todo.Name,
                Description = todo.Description,
                Priority = todo.Priority,
                Status = todo.Status,
                Deadline = todo.Deadline
            });

            repository.SaveChanges();
            var newTodo = repository.Todos.Select(t => new Todo { Id = t.Id, Name = t.Name }).OrderBy(t => t.Id).Last();

            return newTodo;
        }
    }
}
