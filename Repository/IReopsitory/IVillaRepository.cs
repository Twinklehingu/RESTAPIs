using System.Linq.Expressions;
using WebAPIDemos.Models;

namespace WebAPIDemos.Repository.IReopsitory
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
