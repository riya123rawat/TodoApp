using Microsoft.EntityFrameworkCore;
using TodoApp.Models;
namespace TodoApp.Data
{
    public class PersonDbContext:DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }
       // public DbSet<Person> Person { get; set; }
       // public DbSet<Todo> Todo { get; set; }
    }
    
}
