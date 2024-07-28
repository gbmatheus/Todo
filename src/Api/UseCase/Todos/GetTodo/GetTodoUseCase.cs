namespace Api.UseCase.Todos.GetTodos
{
    public class GetTodosResult
    {
        public Todos Execute()
        {
            var repository = new TodoDbContext();
            
            return repository.Todos.First();
        }
    }
}