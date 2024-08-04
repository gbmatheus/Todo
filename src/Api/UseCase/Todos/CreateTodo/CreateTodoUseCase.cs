using Api.Comunnication.Requests.Todo;
using Api.Comunnication.Responses.Todo;
using Api.Domain.Entities;
using Api.Domain.Enums.Todo;
using Api.Repositories;

namespace Api.UseCase.Todos.CreateTodo
{
    public class CreateTodoUseCase
    {
        public ResponseCreatedTodoJson execute(RequestCreateTodoJson request)
        {
            Validate(request);

            //var repository = new TodoDbContext();

            //repository.Add(new Todo
            //{
            //    Name = request.Name,
            //    Description = request.Description,
            //    Priority = request.Priority,
            //    Status = request.Status,
            //    Deadline = request.Deadline
            //});

            //repository.SaveChanges();
            //var todo = repository.Todos.Select(t => new Todo { Id = t.Id, Name = t.Name }).OrderBy(t => t.Id).Last();

            //return new ResponseCreatedTodoJson { Id = todo.Id, Name = todo.Name };
            return new ResponseCreatedTodoJson { Id = 123, Name = request.Name };
        }

        public void Validate(RequestCreateTodoJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new BadHttpRequestException("Name is required");

            if(!Enum.IsDefined(typeof(Status), request.Status))
                throw new BadHttpRequestException("Status is invalid");
            
            if (!Enum.IsDefined(typeof(Priotity), request.Priority))
                throw new BadHttpRequestException("Priority is invalid");

            if (DateTime.UtcNow.Date > request.Deadline)
                throw new BadHttpRequestException("Deadline cannot be in the past");
        }
    }
}
