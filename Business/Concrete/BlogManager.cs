using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal blogDal;
        public BlogManager(IBlogDal BlogDal)
        {
            blogDal = BlogDal;
        }


        public void BlogAdd(Blog blog)
        {
            blogDal.Insert(blog);
        }


        public void BlogDelete(Blog blog)
        {
            blogDal.Delete(blog);
        }


        public void BlogUpdate(Blog blog)
        {
            blogDal.Update(blog);
        }

        public List<Blog> GetBlogById(int id)
        {
            return blogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return blogDal.GetListAll();
        }
    }
}