using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AspNetCore.ApplicationCore.Entities;
using AspNetCore.ApplicationCore.Interfaces.Repositories;
using AspNetCore.ApplicationCore.Interfaces.Services;

namespace AspNetCore.Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task Delete(T entity)
        {
            if (entity == null)
                throw new Exception("Não existem dados para exclusão.");

            await _repository.Delete(entity);
        }

        public async Task DeleteAll(List<T> entities)
        {
            if (entities.Count == 0)
                throw new Exception("Não existem dados para exclusão.");

            await _repository.DeleteAll(entities);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public async Task<List<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetId(long id)
        {
            return await _repository.GetId(id);
        }

        public async Task<T> Post(T entity)
        {
            entity.Created = DateTime.Now;
            entity.Updated = DateTime.Now;

            await _repository.Post(entity);
            return entity;
        }

        public async Task PostAll(List<T> entities)
        {
            //List<T> list = new List<T>();

            foreach(var item in entities)
            {
                item.Created = DateTime.Now;
                item.Updated = DateTime.Now;

                //list.Add(item);
            }

            await _repository.PostAll(entities);
        }

        public async Task<T> Put(T entity)
        {
            entity.Updated = DateTime.Now;

            await _repository.Put(entity);
            return entity;
        }

        public async Task PutAll(List<T> entities)
        {
            foreach(var item in entities)
            {
                item.Updated = DateTime.Now;
            }

            await _repository.PutAll(entities);
        }

        public async Task<List<T>> Search(Expression<Func<T, bool>> predicado)
        {
            return await _repository.Search(predicado);
        }
    }
}