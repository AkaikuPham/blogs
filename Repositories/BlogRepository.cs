using BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BlogRepository: GenericRepository<Blog>, IBlogRepository
    {
        private readonly BlogContext _blogContext1;
    public BlogRepository(BlogContext blogContext) : base(blogContext)
    {
        _blogContext1 = blogContext;
    }

    public List<Blog> getAll()
    {
        return _blogContext1.Blogs.ToList();
    }
}
}
