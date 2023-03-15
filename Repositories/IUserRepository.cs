using BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public List<User> getAll();

        public User GetUser(int Id);
    }
}
