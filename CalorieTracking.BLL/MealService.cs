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
    public class MealService
    {
        public MealService()
        {
            mealManager = new MealManager(new AppDbContext());
        }

        MealManager mealManager;
        
        public bool Add(Meal meal)
        {
            meal.CreationDate = DateTime.Now;
            meal.Status = Status.Active;
            return mealManager.Add(meal);
        }

        public bool Update(Meal meal)
        {
            meal.ModifiedDate = DateTime.Now;
            meal.Status = Status.Modified;
            return mealManager.Update(meal);
        }

        public bool Delete(int id)
        {
            Meal meal = GetById(id);
            return mealManager.Delete(meal);
        }

        public Meal GetById(int id)
        {
            return mealManager.Find(id);
        }

        public List<Meal> GetAllMeals()
        {
          return mealManager.GetMeals();
        }
    }
}
