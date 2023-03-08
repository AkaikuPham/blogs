using BaseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly BlogContext _blogContext;
        public UserRepository(BlogContext blogContext) : base(blogContext)
        {
            _blogContext = blogContext;
        }

        public List<User> getAll()
        {
            return _blogContext.Users.ToList();
        }

        public User GetUser(int Id)
        {
            return _blogContext.Users.Include(x => x.Blogs).Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
