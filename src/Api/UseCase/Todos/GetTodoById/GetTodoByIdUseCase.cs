using Api.Domain.Entities;
using Api.Repositories;

namespace Api.UseCase.Todos.GetTodoById
{
    public class GetTodoByIdUseCase
    {
        public Todo execute(int id)
        {
            var repository = new TodoDbContext();
            var todo = repository.Todos.FirstOrDefault(t => t.Id == id) as Todo;

            if (todo == null) return null;

            return todo;
        }
    }
}
