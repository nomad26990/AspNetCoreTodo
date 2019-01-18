using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services{
    public class FakeTodoItemService : ITodoItemService{
        public Task<TodoItem[]> GetIncompleteItemsAsync()
                {
                    var item1 = new TodoItem{
                        Title = "Learn Asp.NET Core",
                        DueAt = DateTimeOffset.Now.AddDays(1)
                    };

                    var item2 = new TodoItem{
                        Title = "Build ASP.NET Core Apps",
                        DueAt = DateTimeOffset.Now.AddDays(2)
                    };

                    return Task.FromResult(new[] {item1, item2});
                }
    }
}