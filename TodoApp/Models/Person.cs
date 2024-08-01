using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public ICollection<Todo> Todos { get; set; } = new List<Todo>();

        // Parameterless constructor for EF Core
        public Person() { }

        // Constructor with parameters for manual use
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}