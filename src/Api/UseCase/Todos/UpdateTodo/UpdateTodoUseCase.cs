using Api.Comunnication.Requests.UpdateTodo;
using Api.Repositories;

namespace Api.UseCase.Todos.UpdateTodo
{
    public class UpdateTodoUseCase
    {
        public bool execute(int id, RequestUpdateTodoJson todo)
        {
            var repository = new TodoDbContext();

            var todoFounded = repository.Todos.FirstOrDefault(t => t.Id == id);

            if (todoFounded == null) return false;

            if(!string.IsNullOrWhiteSpace(todo.Name))
                todoFounded.Name = todo.Name;
            if (!string.IsNullOrWhiteSpace(todo.Description))
                todoFounded.Description = todo.Description;
            
            if (todo.Deadline > DateTime.Today)
                todoFounded.Deadline = todo.Deadline;
            
            repository.SaveChanges();
            return true;
        }
    }
}
