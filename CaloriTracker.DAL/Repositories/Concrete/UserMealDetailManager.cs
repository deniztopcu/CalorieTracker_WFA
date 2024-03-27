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
    public class UserMealDetailManager : Crud<UserMealDetail>
    {
        public UserMealDetailManager(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;

        }



        public AppDbContext _dbContext;


        public List<Category> GetAllCategories()
        {
            return _dbContext.UserMealDetails
                .Join(_dbContext.Foods, x => x.FoodID, y => y.ID, (x, y) => new { y.Category, x.FoodID, y.CategoryID, x.Status })
                .Where(a => a.Status == Status.Active)
                .Select(a => a.Category)
                .Distinct()
                .ToList();
        }

        public double TotalConsumptionOfCategory(int categoryid, int dayago)
        {
            var result = _dbContext.Foods
                .Join(_dbContext.UserMealDetails, y => y.ID, x => x.FoodID, (y, x) => new { y.CategoryID, y.ID, x.Status, x.FoodCount, x.CreationDate })
                .Where(x => x.CreationDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(n => new { n.CategoryID, n.Status })
                .Select(x => new { x.Key.CategoryID, TotalConsumption = x.Sum(x => x.FoodCount), x.Key.Status })
                .Where(x => x.Status == Status.Active && x.CategoryID == categoryid).FirstOrDefault();
            if (result == null) return 0;
            else return result.TotalConsumption;
        }
        //
        public double ConsumptionOfCategoryByUser(User user, Category category, int dayago)
        {
            int userID = (int)user.ID;
            var result = _dbContext.Foods
                .Join(_dbContext.UserMealDetails, x => x.ID, y => y.FoodID, (x, y) => new { x.CategoryID, x.ID, y.Status, y.FoodCount, y.UserID, y.CreationDate })
                .Where(a => a.CreationDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(x => new { x.CategoryID, x.Status, x.UserID })
                .Select(a => new { a.Key.CategoryID, TotalConsumption = a.Sum(b => b.FoodCount), a.Key.Status, a.Key.UserID })
                .Where(a => a.Status == Status.Active && a.CategoryID == category.ID && a.UserID == userID).FirstOrDefault();

            if (result == null) return 0;
            else return result.TotalConsumption;

        }

        public double TotalCalorieOfCategory(int categoryid, int dayago)
        {
            var result = _dbContext.Foods
                .Join(_dbContext.UserMealDetails, y => y.ID, x => x.FoodID, (y, x) => new { y.CategoryID, y.ID, x.Status, x.FoodCount, y.Calorie, x.CreationDate })
                .Where(x => x.CreationDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(y => new { y.CategoryID, y.Status, y.ID, y.Calorie })
                .Select(x => new { x.Key.CategoryID, TotalCalorie = x.Sum(x => x.FoodCount) * x.Key.Calorie, x.Key.Status })
                .Distinct()
                .GroupBy(y => new { y.CategoryID, y.Status })
                .Select(x => new { x.Key.CategoryID, SumOfCalories = x.Sum(y => y.TotalCalorie), x.Key.Status })
                .Where(x => x.Status == Status.Active && x.CategoryID == categoryid).FirstOrDefault();
            if (result == null) return 0;
            else return result.SumOfCalories;
        }

        public double TotalCalorieOfCategoryByUser(int categoryid, User user, int dayago)
        {
            int userID = user.ID;
            var result = _dbContext.Foods
                .Join(_dbContext.UserMealDetails, y => y.ID, x => x.FoodID, (y, x) => new { y.CategoryID, y.Name, x.Status, x.FoodCount, y.Calorie, x.User.ID, x.CreationDate })
                .Where(x => x.CreationDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(y => new { y.CategoryID, y.Status, y.Name, y.Calorie, y.ID })
                .Select(x => new { x.Key.CategoryID, x.Key.ID, TotalCalorie = x.Sum(x => x.FoodCount) * x.Key.Calorie, x.Key.Status })
                .Distinct()
                .GroupBy(y => new { y.CategoryID, y.Status, y.ID })
                .Select(x => new { x.Key.CategoryID, SumOfCalories = x.Sum(y => y.TotalCalorie), x.Key.Status, x.Key.ID })
                .Where(x => x.Status == Status.Active && x.CategoryID == categoryid && x.ID == userID).FirstOrDefault();
            if (result == null) return 0;
            else return result.SumOfCalories;
        }

        public List<Meal> GetAllMeals(User user)
        {
            return _dbContext.UserMealDetails.Include(x => x.Meal).Where(x => x.Status == Status.Active && x.User == user).Select(x => x.Meal).Distinct().ToList();

        }

        public string GetMealConsumptionsOfAllUsers(Meal meal, int dayago)
        {
            var result = _dbContext.Meals
                .Join(_dbContext.UserMealDetails, x => x.ID, y => y.MealID, (x, y) => new { y.CreationDate, y.Status, y.FoodCount, y.Meal.MealType })
                .Where(x => x.CreationDate > DateTime.Now.AddDays(-dayago) && x.MealType == meal.MealType && x.Status == Status.Active)
                .GroupBy(x => new { x.MealType, x.Status })
                .Select(x => new { TotalConsumption = x.Sum(y => y.FoodCount) })
                .FirstOrDefault();
            return result.TotalConsumption.ToString();
        }

        public string GetMealConsumptionsOfAllUsers(Meal meal, User user, int compareDay)
        {
            int userID = user.ID;
            Meal meal1 = meal;
            var result = _dbContext.Meals
                .Join(_dbContext.UserMealDetails, x => x.ID, y => y.MealID, (x, y) => new { y.CreationDate, y.Status, y.FoodCount, x.MealType, x.ID })
                .Where(x => x.CreationDate > DateTime.Now.AddDays(-compareDay)
                && x.MealType == meal.MealType && x.ID == userID && x.Status == Status.Active)
                .GroupBy(x => new { x.MealType, x.Status, x.ID })
                .Select(x => new { TotalConsumption = x.Sum(y => y.FoodCount) })
                .FirstOrDefault();
            return result.TotalConsumption.ToString();
        }

        public string GetMealCaloriesOfAllUsers(Meal meal, int compareDay)
        {
            return _dbContext.Meals
                .Join(_dbContext.UserMealDetails, x => x.ID, y => y.MealID, (x, y) => new { y.CreationDate, y.Status, y.FoodCount, x.MealType, y.FoodID })
                .Where(x => x.CreationDate > DateTime.Now.AddDays(-compareDay) && x.MealType == meal.MealType && x.Status == Status.Active)
                .Join(_dbContext.Foods, x => x.FoodID, n => n.ID, (x, n) => new { x.MealType, x.FoodCount, n.Calorie })
                .GroupBy(x => new { x.MealType, x.Calorie })
                .Select(x => new { x.Key.MealType, TotalConsumption = x.Sum(y => y.FoodCount) * x.Key.Calorie })
                .Distinct()
                .GroupBy(x => x.MealType)
                .Select(x => new { SumOfCalories = x.Sum(x => x.TotalConsumption) })
                .ToList().FirstOrDefault().SumOfCalories.ToString();
        }

        public string GetMealCaloriesOfAllUsers(Meal meal, User user, int compareDay)
        {
            return _dbContext.Meals
                .Join(_dbContext.UserMealDetails, x => x.ID, y => y.MealID, (x, y) => new { y.CreationDate, y.Status, y.FoodCount, x.MealType, y.FoodID, y.UserID })
                .Where(x => x.CreationDate > DateTime.Now.AddDays(-compareDay) && x.MealType == meal.MealType && x.Status == Status.Active && x.UserID == user.ID)
                .Join(_dbContext.Foods, x => x.FoodID, y => y.ID, (x, y) => new { x.MealType, x.FoodCount, y.Calorie })
                .GroupBy(x => new { x.MealType, x.Calorie })
                .Select(x => new { x.Key.MealType, TotalConsumption = x.Sum(y => y.FoodCount) * x.Key.Calorie })
                .Distinct()
                .GroupBy(x => x.MealType)
                .Select(x => new { SumOfCalories = x.Sum(x => x.TotalConsumption) })
                .ToList().FirstOrDefault().SumOfCalories.ToString();
        }

        public int GetCountOfUsersSpecificMeal(Meal meal, User user)
        {
            int userID = user.ID;
            int mealID = meal.ID;
            return _dbContext.UserMealDetails
                .Where(x => x.MealID == mealID && x.Status == Status.Active && x.UserID == userID)
                .GroupBy(x => x.CreationDate.Date)
                .Select(x => x.Key.Date)
                .ToList().Count();
        }
        public string GetTotalCalorieOfSpecificMealOfUser(Meal meal, User user)
        {
            int userID = user.ID;
            int mealID = meal.ID;
            double calorie = 0;
            foreach (UserMealDetail item in _dbContext.UserMealDetails.Where(x => x.UserID == userID && x.MealID == mealID && x.Status == Status.Active).ToList())
            {
                int foodID = item.FoodID;
                var food = _dbContext.Foods.Where(x => x.ID == foodID).FirstOrDefault();
                calorie += (item.FoodCount) * food.Calorie;
            }
            return calorie.ToString();
        }
        public List<UserMealDetail> GetUserMealHistoryOfMeal(int mealid, int userID)
        {
            return _dbContext.UserMealDetails
                .Where(x => x.MealID == mealid && x.Status == Status.Active && x.UserID == userID)
                .ToList();
        }

        public List<UserMealDetail> GetUserMealHistoryByUserID(int userID)
        {
            return _dbContext.UserMealDetails
                .Where(x => x.UserID == userID && x.Status == Status.Active)
                .ToList();
        }

        public void GetUserMealHistoryByHistory(UserMealDetail userMealDetail)
        {

            var meals = from f in _dbContext.Foods
                        join um in _dbContext.UserMealDetails on f.ID equals um.FoodID
                        join u in _dbContext.Users on um.UserID equals u.ID
                        where u.ID == userMealDetail.UserID
                        select new { um.CreationDate, f.Calorie };

            meals.GroupBy(x => x.CreationDate.Date).Select(group => new
            {
                Tarih = group.Key,
                TotalKalori = group.Sum(x => x.Calorie)
            }).ToList();


            //List<> listData = queryableData.ToList();


        }

        public double TodayTotalMealCalorie(int userID, string mealName)
        {
            double totalMealCalorie = 0;
            foreach (var item in _dbContext.UserMealDetails.Include(x => x.Meal).Where(x => x.UserID == userID && x.Meal.MealType.ToString() == mealName && x.CreationDate.Date == DateTime.Now.Date && x.Status == Status.Active).ToList())
            {
                totalMealCalorie += item.TotalCalorie;
            }
            return totalMealCalorie;







        }


        public IEnumerable<dynamic> GetMealsTodayCalorie(int userID)
        {

            var list = _dbContext.UserMealDetails.Join(_dbContext.Meals, x => x.MealID, y => y.ID, (x, y) => new { x.CreationDate, y.MealType, x.TotalCalorie, x.UserID }).Where(x => x.CreationDate.Date == DateTime.Today && x.UserID == userID).GroupBy(x => x.MealType).Select(group => new
            {
                OgunAdi = group.Key,
                ToplamKalori = group.Sum(x => x.TotalCalorie)
            }
            ).ToList();

            return list;

        }

        public IEnumerable<dynamic> GetDaysCalorie(int userID)
        {

            var list = _dbContext.UserMealDetails.Where(x => x.UserID == userID).GroupBy(x => x.CreationDate.Date).Select(group => new
            {
                Tarih = group.Key,
                ToplamKalori = group.Sum(x => x.TotalCalorie)
            }).ToList();
            return list;

        }
    }



}
