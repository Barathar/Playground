using System.Collections.Generic;
using System.Threading.Tasks;
using CanIEatApi.Domain.Models;

namespace CanIEatApi.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}