using BaseModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BlogContext _blogContext; // là field
        private readonly DbSet<T> _dbSet; // là field

        public GenericRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
            _dbSet = _blogContext.Set<T>(); // Lấy 1 DB set trong DB context, lấy được dữ liệu trong DB
        }

        public void create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void delete(int Id)
        {
            T entity = _dbSet.Find(Id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public T getById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public void update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
