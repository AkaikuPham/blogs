using BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _blogContext;
        public IBlogRepository _blogRepository;
        public IUserRepository _userRepository;
        public UnitOfWork (BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public BlogContext BlogContext => _blogContext;

        public IUserRepository UserRepository
        {
            get {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_blogContext);
                }
                return _userRepository;
            }
        }

        public IBlogRepository BlogRepository
        {
            get
            {
                if (_blogRepository == null)
                {
                    _blogRepository = new BlogRepository(_blogContext);
                }
                return _blogRepository;
            }
        }
        public int SaveChange()
        {
            return _blogContext.SaveChanges();
        }
    }
}
