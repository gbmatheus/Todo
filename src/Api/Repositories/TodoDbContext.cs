using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;

namespace Api.Repositories
{
    public class TodoDbContext: DbContext
    {

        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\github\gbmatheus\Todo-DB\todo.db");
        }
    }
}