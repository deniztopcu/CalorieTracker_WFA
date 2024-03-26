using CaloriTracker.DAL.Repositories.Concrete;
using CaloriTracker.DAL;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracking.BLL
{
    public class UserMealDetailService
    {
        public UserMealDetailService()
        {
            userMealDetailManager = new UserMealDetailManager(new AppDbContext());
        }

        UserMealDetailManager userMealDetailManager;

        public bool Add(UserMealDetail userMealDetail)
        {
            userMealDetail.CreationDate = DateTime.Now;
            userMealDetail.Status = Status.Passive;
            return userMealDetailManager.Add(userMealDetail);
        }

        public bool Update(UserMealDetail userMealDetail, Status status = Status.Modified)
        {
            userMealDetail.ModifiedDate = DateTime.Now;
            userMealDetail.Status = status;
            return userMealDetailManager.Update(userMealDetail);
        }

        public bool Delete(int id)
        {
            UserMealDetail userMealDetail = GetById(id);
            return userMealDetailManager.Delete(userMealDetail);
        }

        public UserMealDetail GetById(int id)
        {
            return userMealDetailManager.Find(id);
        }

        public List<Category> GetAllCategories()
        {
            return userMealDetailManager.GetAllCategories();
        }

        public double TotalConsumptionOfCategory(int id, int gun)
        {
            return userMealDetailManager.TotalConsumptionOfCategory( id, gun);
        }

        public double ConsumptionOfCategoryByUser(User user, Category category, int gun)
        {
            return userMealDetailManager.ConsumptionOfCategoryByUser(user, category, gun);
        }

        public double TotalCalorieOfCategory(int categoryid, int gun)
        {
            return userMealDetailManager.TotalCalorieOfCategory(categoryid, gun);
        }

        public double TotalCalorieOfCategoryByUser(int categoryid, User user, int gun)
        {
            return userMealDetailManager.TotalCalorieOfCategoryByUser(categoryid, user, gun);
        }
        public List<Meal> GetAllMeals(User user)
        {
            return userMealDetailManager.GetAllMeals(user);
        }

        public string GetMealConsumptionsOfAllUsers(Meal meal, int gun)
        {
            return userMealDetailManager.GetMealConsumptionsOfAllUsers(meal, gun);
        }
        public string  GetMealConsumptionsOfAllUsers(Meal meal, User user, int compareDay)
        {
            return userMealDetailManager.GetMealConsumptionsOfAllUsers(meal, user, compareDay);
        }
        public string GetMealCaloriesOfAllUsers(Meal meal, int compareDay)
        {
            return userMealDetailManager.GetMealCaloriesOfAllUsers(meal, compareDay);
        }

        public string GetMealCaloriesOfAllUsers(Meal meal, User user, int compareDay)
        {
            return userMealDetailManager.GetMealCaloriesOfAllUsers(meal,user ,compareDay);
        }

        public int GetCountOfUsersSpecificMeal(Meal meal, User user)
        {
            return userMealDetailManager.GetCountOfUsersSpecificMeal(meal, user);
        }

        public string GetTotalCalorieOfSpecificMealOfUser(Meal meal, User user)
        {
            return userMealDetailManager.GetTotalCalorieOfSpecificMealOfUser(meal, user);
        }
        public List<UserMealDetail> GetUserMealHistoryOfMeal(int mealid)
        {
            return userMealDetailManager.GetUserMealHistoryOfMeal(mealid);
        }


        public List<UserMealDetail> GetUserMealHistoryByUserID(int userID)
        {
            return userMealDetailManager.GetUserMealHistoryByUserID(userID);
        }
    }
}
