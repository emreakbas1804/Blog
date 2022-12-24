using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal CategoryDal)
        {
            categoryDal = CategoryDal;
        }
        public void CategoryAdd(Category category)
        {
            categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetListAll();
        }
    }
}