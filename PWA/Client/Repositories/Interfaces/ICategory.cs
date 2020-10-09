using PWA.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories.Interfaces
{
    public interface ICategory
    {
        Task CreateCategory(Category category);
        Task DeleteCategory(int Id);
        Task<List<Category>> GetCategory();
        Task<Category> GetCategory(int Id);
        Task UpdateCategory(Category category);
    }
}
