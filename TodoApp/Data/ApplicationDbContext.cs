using Microsoft.EntityFrameworkCore;
using TodoApp.Models;
using TodoApp.Data;

namespace TodoApp.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
    

}

