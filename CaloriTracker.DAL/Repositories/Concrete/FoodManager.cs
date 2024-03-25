using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.Repositories.Concrete
{
    public class FoodManager : Crud<Food>
    {
        public FoodManager(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public AppDbContext _dbContext;

        public List<Food> GetFoodsByCategoryID(int categoryID)
        {
            return _dbContext.Foods.Where(x => (x.CategoryID == categoryID && x.Status != Status.Passive)).ToList();
        }
        public List<Food> GetFoods()
        {
            return _dbContext.Foods.ToList();
        }


        public Food GetFoodByName(string foodName)
        {
            var food = _dbContext.Foods.FirstOrDefault(x => x.Name == foodName);
            return food;

        }
    }
}
