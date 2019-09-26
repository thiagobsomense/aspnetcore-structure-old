using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AspNetCore.ApplicationCore.Interfaces.Repositories
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        Task<T> Post(T entity);
        Task PostAll(List<T> entities);
        Task<T> Put(T entity);
        Task PutAll(List<T> entities);
        Task<List<T>> GetAll();
        Task<T> GetId(long id);
        Task<List<T>> Search(Expression<Func<T, bool>> predicado);
        Task Delete(T entity);
        Task DeleteAll(List<T> entities);
    }
}