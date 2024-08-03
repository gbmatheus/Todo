using Api.Domain.Entities;
using Api.Repositories;
using System.Collections.Generic;

namespace Api.UseCase.Todos.GetTodos
{
    public class GetTodos
    {
        public List<Todo> Execute()
        {
            var repository = new TodoDbContext();

            return repository.Todos.ToList();
        }
    }
}