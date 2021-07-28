using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MundoNews.Domain.Repos.Base.Api
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task<TEntity> Insert(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task Delete(int id);
    }
}

