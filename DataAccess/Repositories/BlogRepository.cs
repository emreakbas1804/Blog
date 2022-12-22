using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entity.Concrete;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogDal
    {
        BlogContext context = new BlogContext();
        public void AddBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

        public void Delete(Blog entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            context.Blogs.Remove(blog);
            context.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return context.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Blog entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            return context.Blogs.ToList();
        }

        public void Update(Blog entity)
        {
            throw new System.NotImplementedException();
        }
    }
}