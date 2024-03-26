using CaloriTracker.DAL;
using CaloriTracker.DAL.Repositories.Concrete;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracking.BLL
{
    public class FoodService
    {
        public FoodService()
        {
            foodManager = new FoodManager(new AppDbContext());
        }
        FoodManager foodManager;
        public bool Add(Food food)
        {
            food.CreationDate = DateTime.Now;
            food.Status = Status.Passive;
            return foodManager.Add(food);
        }

        public bool Update(Food food)
        {
            food.ModifiedDate = DateTime.Now;
            food.Status = Status.Modified;
            return foodManager.Update(food);
        }

        public bool Delete(int id)
        {
            Food food = GetById(id);
            return foodManager.Delete(food);
        }

        public Food GetById(int id)
        {
            return foodManager.Find(id);
        }
        public List<Food> GetFoodsByCategoryID(int categoryID)
        {
            return foodManager.GetFoodsByCategoryID(categoryID);
        }
        public bool CheckEntries(string foodName)
        {
            if (foodManager.GetFoodByName(foodName) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public List<Food> GetAllFoods()
        {
            return foodManager.GetAllFoods();
        }

        public Food GetFoodByID(int id)
        {
            return foodManager.GetFoodByID(id);
        }


    }
}
