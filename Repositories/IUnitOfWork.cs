using BaseModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }

        public IBlogRepository BlogRepository { get; }

        public BlogContext BlogContext { get; }

        public int SaveChange();
    }
}
