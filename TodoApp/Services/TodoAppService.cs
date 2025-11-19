using TodoApp.Entities;
using Volo.Abp.Domain.Repositories;

namespace TodoApp.Services
{
    public class TodoAppService : TodoAppAppService
    {
        private IRepository<TodoItem, Guid> _todoItemRepository;

        public TodoAppService(IRepository<TodoItem, Guid> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
    }
}
