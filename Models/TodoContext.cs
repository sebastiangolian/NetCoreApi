using Microsoft.EntityFrameworkCore;

namespace NetCoreApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .Property(b => b.IsComplete)
                .IsRequired();
        }

        public DbSet<Todo> TodoItems { get; set; }
    }
}