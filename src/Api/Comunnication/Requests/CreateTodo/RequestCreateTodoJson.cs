namespace Api.Comunnication.Requests.CreateTodo
{
    public class RequestCreateTodoJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; }
        public int Status { get; set; }
        public DateTime Deadline { get; set; }

    }
}
