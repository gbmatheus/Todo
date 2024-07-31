using Api.Repositories;

namespace Api.UseCase.Todos.DeleteTodo
{
    public class DeleteTodoUseCase
    {
        public bool execute(int id)
        {
            var repository = new TodoDbContext();
            
            var todo = repository.Todos.FirstOrDefault(t => t.Id == id);

            if (todo == null) return false;

            repository.Remove(todo);
            repository.SaveChanges();
            return true;
        }
    }
}
