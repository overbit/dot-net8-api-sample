using System.ComponentModel.DataAnnotations;
using MyService.APIs.Author.Dtos;
using MyService.APIs.Todo.Dtos;


public interface ITodoItemsService
{
    public Task<IEnumerable<TodoItemDto>> TodoItems();

    public Task<TodoItemDto> TodoItem(long id);

    public Task UpdateTodoItem(long id, TodoItemDto dto);

    public Task<TodoItemDto> CreateTodoItem(TodoItemDto dto, long workspaceId);

    public Task DeleteTodoItem(long id);

    public Task<IEnumerable<AuthorDto>> Authors(long id);

    public Task ConnectAuthor(long id, [Required] long authorId);

    public Task DisconnectAuthor(long id, [Required] long authorId);
}