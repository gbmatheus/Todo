namespace Api.Entities
{
    public class Todo
    {
        public int Id { get; set;}
        public string Name { get; set;} = string.Empty;
        public string Description { get; set;} = string.Empty ;
        public int Priority { get; set;}
        public int Status { get; set;}
        public DateTime Deadline { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
