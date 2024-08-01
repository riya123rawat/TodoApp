using Microsoft.AspNetCore.Mvc;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(_context.People.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(int id)
        {
            var person = _context.People.Find(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPerson), new { id = person.Id }, person);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            var person = _context.People.Find(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.People.Remove(person);
            _context.SaveChanges();
            return NoContent();
        }
    }
}