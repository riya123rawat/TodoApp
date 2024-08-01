using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public bool Done { get; set; }

        public int? AssigneeId { get; set; }
        public Person Assignee { get; set; } 

        // Parameterless constructor for EF Core
        public Todo() { }

        // Constructor with parameters for manual use
        public Todo(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
