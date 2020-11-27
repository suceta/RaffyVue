using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RaffyVue.Repository.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<T> Create(T entity);

        Task<bool> CreateRange(IEnumerable<T> entities);

        Task<bool> Delete(int id);

        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> FindFilter(Expression<Func<T, bool>> where);

        Task<T> FindById(int id);

        Task<T> FindFilterFirst(Expression<Func<T, bool>> where);

        Task<T> Update(T entity);
    }   
}
