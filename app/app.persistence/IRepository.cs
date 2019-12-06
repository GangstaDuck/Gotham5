using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.persistence
{
    public interface IRepository<T> where T : Entity
    {
        Task<IQueryable<T>> GetAll();

        Task<T> GetById(int? id);

        Task Delete(T entity);

        Task Add(T entity);

        Task Update(T entity);
    }
}
