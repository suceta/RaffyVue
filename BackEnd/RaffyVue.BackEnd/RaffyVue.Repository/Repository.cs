

namespace RaffyVue.Repository
{
    using Microsoft.EntityFrameworkCore;
    using RaffyVue.DataModels;
    using RaffyVue.Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly VueDBContext context;

        public Repository(VueDBContext dbcont)
        {
            this.context = dbcont;
        }

        #region implement interface *************************************

        //TODO agregar queryable

        public async Task<T> Create(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> CreateRange(IEnumerable<T> entities)
        {
            await context.Set<IEnumerable<T>>().AddRangeAsync(entities);
            return await context.SaveChangesAsync() > 0;
        }

        //TODO
        public async Task<bool> Delete(int id)
        {
            T entity = await context.Set<T>().FindAsync(id);
            context.Remove(entity);
            return await context.SaveChangesAsync() > 0;
        }

        //TODO
        public async Task<IEnumerable<T>> FindFilter(Expression<Func<T, bool>> where)
        {
            return await context.Set<T>().Where(where).ToListAsync();
        }

        //TODO poner companyID filrado
        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        //TODO
        public async Task<T> FindById(int id)
        {
            return await context.Set<T>().FindAsync(id); ;
        }
        public async Task<T> FindFilterFirst(Expression<Func<T, bool>> where)
        {
            return await context.Set<T>().FindAsync(where);
        }

        public async Task<T> Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }
        #endregion
    }
}
