using Microsoft.EntityFrameworkCore;

namespace DiveAPI.Models {
    public class TodoContext : DbContext {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) {

        }

        public DbSet<TodoItem> TodoItems { get; set;}
    }
}