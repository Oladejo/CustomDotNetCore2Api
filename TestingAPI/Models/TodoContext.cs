using Microsoft.EntityFrameworkCore;

namespace TestingAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
