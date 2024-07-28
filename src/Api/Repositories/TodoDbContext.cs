using Microsoft.EntityFrameworkCore;
using Api.Entities;

namespace Api.Repositories
{
    public class TodoDbContext: DbContext
    {

        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\github\gbmatheus\Todo\todo.db");
        }
    }
}