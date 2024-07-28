
using TodoApp.Data;
using TodoApp.Models;

namespace Console_Core_Project.Data
{
}
public class PeopleService
{
    private readonly PersonDbContext _context;
    public PeopleService(PersonDbContext context)
    {
        _context = context;
    }
    private static Person[] personArray = new Person[0];
    //add method
    public int Size() => personArray.Length;

    public Person[] FindAll() => personArray;

    public Person FindById(int personId) => personArray.FirstOrDefault(person => person.Id == personId);

    public Person CreatePerson(string firstName, string lastName)
    {
        int newId = PersonSequencer.NextPersonId();
        Person newPerson = new Person(newId, firstName, lastName);
        Array.Resize(ref personArray, personArray.Length + 1);
        personArray[personArray.Length - 1] = newPerson;
        return newPerson;
    }

    public void Clear() => personArray = new Person[0];

    public void RemovePerson(int personId)
    {
        int index = Array.FindIndex(personArray, p => p.Id == personId);
        if (index >= 0)
        {
            Person[] newArray = new Person[personArray.Length - 1];
            if (index > 0)
            {
                Array.Copy(personArray, 0, newArray, 0, index);
            }
            if (index < personArray.Length - 1)
            {
                Array.Copy(personArray, index + 1, newArray, index, personArray.Length - index - 1);
            }
            personArray = newArray;
        }
    }

}