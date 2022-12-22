using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entity.Concrete;

namespace DataAccess.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        BlogContext context = new BlogContext();
        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return context.Categories.ToList();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}