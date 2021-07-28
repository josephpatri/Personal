﻿using MundoNews.DistributedService.Services.Int.Base;
using MundoNews.Domain.Repos.Base.Api;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MundoNews.DistributedService.Services.Imp.Base
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private IGenericRepository<TEntity> genericRepository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public async Task Delete(int id)
        {
            await genericRepository.Delete(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await genericRepository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await genericRepository.GetById(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            return await genericRepository.Insert(entity);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            return await genericRepository.Update(entity);
        }
    }
}
