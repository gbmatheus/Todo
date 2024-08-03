using Api.Domain.Enums.Todo;

namespace Api.Entities
{
    public class Todo
    {
        public int Id { get; set;}
        public string Name { get; set;} = string.Empty;
        public string Description { get; set;} = string.Empty ;
        public Priotity Priority { get; set;}
        public Status Status { get; set;}
        public DateTime Deadline { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime Created_At { get; set; }
    }
}
