using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Data
{

    public class TodoService
    {
        private readonly PersonDbContext _context;
        public TodoService(PersonDbContext context)
        {
            _context = context;
        }
        // Private static Todo array
        private static Todo[] todoItems = new Todo[0];

        // Method to return the length of the array
        public int Size()
        {
            return todoItems.Length;
        }

        // Method to return the Todo array
        public Todo[] FindAll()
        {
            return todoItems;
        }

        // Method to return the Todo that has a matching todoId
        public Todo FindById(int todoId)
        {
            return todoItems.FirstOrDefault(t => t.Id == todoId);
        }

        // Method to create a new Todo and add it to the array
        public Todo CreateTodo(string description)
        {
            int todoId = TodoSequencer.NextTodoId();
            Todo newTodo = new Todo(todoId, description);

            Array.Resize(ref todoItems, todoItems.Length + 1);
            todoItems[^1] = newTodo;

            return newTodo;
        }

        // Method to clear all Todo objects from the Todo array
        public void Clear()
        {
            todoItems = new Todo[0];
        }
        // Method to find Todos by done status
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            return todoItems.Where(todo => todo.Done == doneStatus).ToArray();
        }

        // Method to find Todos by assignee's personId
        public Todo[] FindByAssignee(int personId)
        {
            return todoItems.Where(todo => todo.Assignee != null && todo.Assignee.Id == personId).ToArray();
        }

        // Method to find Todos by assignee (Person)
        public Todo[] FindByAssignee(Person assignee)
        {
            return todoItems.Where(todo => todo.Assignee == assignee).ToArray();
        }

        // Method to find unassigned Todos
        public Todo[] FindUnassignedTodoItems()
        {
            return todoItems.Where(t => t.Assignee == null).ToArray();
        }
    }
}
