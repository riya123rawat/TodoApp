namespace TodoApp.Models
{

    public class Person
    {
        private readonly int id;
        private string firstName;
        private string lastName;

        //Constructor
        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // public properties to access private field while getting and setting

        public int Id => this.id;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName cannot be null or empty.");
                }
                else
                    firstName = value;

            }

        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName cannot be null or empty.");
                }
                else
                    lastName = value;

            }

        }

    }
}
