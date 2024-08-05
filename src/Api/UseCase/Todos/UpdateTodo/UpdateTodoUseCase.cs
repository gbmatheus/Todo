using Api.Comunnication.Requests.Todo;
using Api.Domain.Enums.Todo;
using Api.Repositories;

namespace Api.UseCase.Todos.UpdateTodo
{
    public class UpdateTodoUseCase
    {
        public bool execute(int id, RequestUpdateTodoJson request)
        {
            Validate(request);
            
            var repository = new TodoDbContext();
            var todo = repository.Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return false;

            if(!string.IsNullOrWhiteSpace(request.Name))
                todo.Name = request.Name;
            if (!string.IsNullOrWhiteSpace(request.Description))
                todo.Description = request.Description;
            
            if (request.Deadline > DateTime.Today)
                todo.Deadline = (DateTime)request.Deadline;
            
            repository.SaveChanges();
            return true;
        }

        public void Validate(RequestUpdateTodoJson request)
        {
            if (request.Priority != null && Enum.IsDefined(typeof(Priotity), request.Priority))
                throw new BadHttpRequestException("Priority is invalid");

            if (request.Status != null && Enum.IsDefined(typeof(Status), request.Status))
                throw new BadHttpRequestException("Status is invalid");

            if (request.Deadline != null && DateTime.UtcNow > request.Deadline)
                throw new BadHttpRequestException("Deadline cannot be in the past");

        }
    }
}
