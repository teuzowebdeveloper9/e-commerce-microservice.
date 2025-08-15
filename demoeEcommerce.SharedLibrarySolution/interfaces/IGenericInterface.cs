using System.Linq.Expressions;
using demoeEcommerce.SharedLibrarySolution.Response;

namespace demoeEcommerce.SharedLibrarySolution.interfaces;

public interface IGenericInterface<T> where T : class
{
    Task<ResponseEntity> CreateAsync(T entity);
    Task<ResponseEntity> DeleteAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> GetByAsync(Expression<Func<T, bool>>  predicate);
    

}