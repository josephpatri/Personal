using Microsoft.EntityFrameworkCore;
using MundoNews.Domain.Data;
using MundoNews.Domain.Repos.Base.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundoNews.Domain.Repos.Imp.Base
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext ApplicationDbContext;

        public GenericRepository(ApplicationDbContext _applicationDbContext)
        {
            ApplicationDbContext = _applicationDbContext;
        }

        public int Count()
        {
            return ApplicationDbContext.Set<TEntity>().ToList().Count();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            ApplicationDbContext.Set<TEntity>().Remove(entity);
            await ApplicationDbContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await ApplicationDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await ApplicationDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            await ApplicationDbContext.Set<TEntity>().AddAsync(entity);
            await ApplicationDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            ApplicationDbContext.Set<TEntity>().Update(entity);
            await ApplicationDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
