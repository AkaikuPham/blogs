using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        public void create(T entity);

        public void update(T entity);

        public void delete(int Id);

        public T getById(int Id);

    }
}
