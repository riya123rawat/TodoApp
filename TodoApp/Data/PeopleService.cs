
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Data
{

    public class PeopleService
    {
        private readonly ApplicationDbContext _context;
        public PeopleService(ApplicationDbContext context)
        {
            _context = context;
        }
        private static Person[] _people = new Person[0];

        public int Size() => _people.Length;

        public Person[] FindAll() => _people;

        public Person? FindById(int personId) =>
            _people.FirstOrDefault(p => p.Id == personId);

        public Person CreatePerson(string firstName, string lastName)
        {
            int newId = PersonSequencer.NextPersonId();
            Person newPerson = new Person(newId, firstName, lastName);
            Array.Resize(ref _people, _people.Length + 1);
            _people[^1] = newPerson;
            return newPerson;
        }

        public void Clear() => _people = new Person[0];
    }
}