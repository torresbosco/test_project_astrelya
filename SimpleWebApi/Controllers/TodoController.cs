using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private static List<TodoItem> todos = new List<TodoItem>
        {
            new TodoItem { Id = 1, Title = "Sample Todo", IsCompleted = false, CreatedAt = DateTime.Now }
        };

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetTodos()
        {
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodo(int id)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }

        [HttpPost]
        public ActionResult<TodoItem> CreateTodo([FromBody] TodoItem todo)
        {
            todo.Id = todos.Max(t => t.Id) + 1;
            todos.Add(todo);
            return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTodo(int id, [FromBody] TodoItem updatedTodo)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            todo.Title = updatedTodo.Title;
            todo.IsCompleted = updatedTodo.IsCompleted;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTodo(int id)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            todos.Remove(todo);
            return NoContent();
        }
    }
}