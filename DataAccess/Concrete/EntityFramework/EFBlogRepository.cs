using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        BlogContext context = new BlogContext();
        public List<Blog> GetListWithCategory()
        {
            return context.Blogs.Include(i => i.Category).ToList();;
        }
    }
}