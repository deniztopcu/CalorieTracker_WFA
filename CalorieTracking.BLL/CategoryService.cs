using CaloriTracker.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloriTracker.DAL;
using Models.Enums;
using System.Net;
using Models.Concrete;

namespace CalorieTracking.BLL
{
    public class CategoryService
    {
        public CategoryService()
        {
            categoryManager = new CategoryManager(new AppDbContext());
        }
        CategoryManager categoryManager;

        public bool Add(Category category)
        {
            category.CreationDate = DateTime.Now;
            category.Status = Status.Active;
            return categoryManager.Add(category);
        }

        public bool Update(Category category)
        {
            category.ModifiedDate = DateTime.Now;
            category.Status = Status.Modified;
            return categoryManager.Update(category);
        }

        public bool Delete(int id)
        {
            Category category = GetById(id);
            return categoryManager.Delete(category);
        }

        public Category GetById(int id)
        {
            return categoryManager.Find(id);
        }

    }
}
