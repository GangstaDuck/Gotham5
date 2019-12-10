using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.persistence
{
    public class AppRepository<T> : IRepository<T> where T : Entity
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public AppRepository(IServiceScopeFactory scopeFactory)
        {
            this._scopeFactory = scopeFactory;
        }

        public async Task Add(T entity)
        {
            using (var scope = this._scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppContext>();
                var entities = db.Set<T>();

                await entities.AddAsync(entity);
                await db.SaveChangesAsync();
            }
        }

        public async Task Delete(T entity)
        {
            using (var scope = this._scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppContext>();
                var entities = db.Set<T>();

                entities.Remove(entity);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IQueryable<T>> GetAll()
        {
            using (var scope = this._scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppContext>();
                var entities = db.Set<T>();

                await db.SaveChangesAsync();
                return (IQueryable<T>)entities.ToList();
            }
        }

        public async Task<T> GetById(int? id)
        {
            using (var scope = this._scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppContext>();

                if (id == null || id < 0)
                {
                    return null;
                }
                else
                {
                    var entities = db.Set<T>();
                    var entity = await entities.FindAsync(id);

                    if (entity == null)
                    {
                        return null;
                    }
                    return entity;
                }
            }
        }

        public async Task Update(T entity)
        {
            using (var scope = this._scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppContext>();
                var entities = db.Set<T>();

                entities.Update(entity);
                await db.SaveChangesAsync();
            }
        }
    }
}
