using Api.Domain.Enums.Todo;

namespace Api.Comunnication.Requests.Todo
{
    public class RequestCreateTodoJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priotity Priority { get; set; }
        public Status Status { get; set; }
        public DateTime Deadline { get; set; }

    }
}
