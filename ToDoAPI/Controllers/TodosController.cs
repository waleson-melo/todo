using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;
using ToDoAPI.DTOs;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    private readonly TodoContext _context;
    private readonly IMapper _mapper;

    public TodosController(TodoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItemDTO>>> GetTodos()
    {
        throw new NotImplementedException("This method is not implemented yet.");
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItemDTO>> GetTodoItem(int id)
    {
        throw new NotImplementedException("This method is not implemented yet.");
    }

    [HttpPost]
    public async Task<ActionResult<TodoItemDTO>> CreateTodoItem(CreateTodoItemDTO dto)
    {
        throw new NotImplementedException("This method is not implemented yet.");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTodoItem(int id, UpdateTodoItemDTO item)
    {
        throw new NotImplementedException("This method is not implemented yet.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoItem(int id)
    {
        throw new NotImplementedException("This method is not implemented yet.");
    }
}
