namespace TodoApp.Models
{   public class Todo
    {
        // Private fields
        private readonly int id;
        private string description;
        private bool done;
        private Person assignee;

        // Constructor
        public Todo(int id, string description)
        {
            this.id = id;
            Description = description;
            done = false;
        }

        // Properties
        public int Id => id;

        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                description = value;
            }
        }

        public bool Done
        {
            get => done;
            set => done = value;
        }

        public Person Assignee
        {
            get => assignee;
            set => assignee = value;
        }

}    }
