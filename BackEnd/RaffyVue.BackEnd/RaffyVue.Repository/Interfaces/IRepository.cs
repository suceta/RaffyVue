using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffyVue.Repository.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetByIdAsync(int id);

        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);
    }   
}
