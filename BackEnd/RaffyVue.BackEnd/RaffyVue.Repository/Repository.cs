

namespace RaffyVue.Repository
{
    using Microsoft.EntityFrameworkCore;
    using RaffyVue.DataModels;
    using RaffyVue.Repository.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly VueDBContext context;

        public Repository(VueDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();       
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
                
        }

        public async Task<T> CreateAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            this.context.Set<T>().Update(entity);
            await SaveAllAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            this.context.Set<T>().Remove(entity);
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}
