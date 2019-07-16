using System.Collections.Generic;
using System.Threading.Tasks;
using CanIEatApi.Domain.Models;

namespace CanIEatApi.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}