using System.Collections.Generic;
using System.Threading.Tasks;
using CanIEatApi.Domain.Models;
using CanIEatApi.Domain.Repositories;
using CanIEatApi.Domain.Services;

namespace CanIEatApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}