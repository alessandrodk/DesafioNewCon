using Business.Interface.IRepository;
using DataAcess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private DbContext _DbContext { get; set; }

        private DbSet<TEntity> _dbset { get; set; }
        public Repository(DbContext applicationDbContext)
        {
            _DbContext = applicationDbContext;
            _dbset = _DbContext.Set<TEntity>();
        }
        public async Task Add(TEntity entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
           return await _dbset.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbset.Where(expression).ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task saveAsync()
        {
           await _DbContext.SaveChangesAsync();
        }
        public  void Save()
        {
             _DbContext.SaveChanges();
        }


        public void Update(TEntity entity)
        {
            _dbset.Update(entity);
        }

    }
}
