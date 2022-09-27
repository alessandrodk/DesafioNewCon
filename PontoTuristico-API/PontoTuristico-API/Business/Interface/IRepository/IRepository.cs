using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface.IRepository
{
    public interface IRepository<TEntity>
    {
        Task Add(TEntity entity);
        void Update(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> expression);
        Task Delete(TEntity entity);
        Task saveAsync();
        void Save();

    }
}
