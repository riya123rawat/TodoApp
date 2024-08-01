using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

using TodoApp.Data;

namespace TodoApp.Data
{

    public class TodoService
    {
        private readonly ApplicationDbContext _context;
        public TodoService(ApplicationDbContext context)
        {
            _context = context;
        }
        private static Todo[] _todos = new Todo[0];

        public int Size() => _todos.Length;

        public Todo[] FindAll() => _todos;

        public Todo? FindById(int todoId) =>
            _todos.FirstOrDefault(t => t.Id == todoId);

        public Todo CreateTodoItem(string description)
        {
            int newId = TodoSequencer.NextTodoId();
            Todo newTodo = new Todo { Id = newId, Description = description };
            Array.Resize(ref _todos, _todos.Length + 1);
            _todos[^1] = newTodo;
            return newTodo;
        }

        public void Clear() => _todos = new Todo[0];
    }
}
