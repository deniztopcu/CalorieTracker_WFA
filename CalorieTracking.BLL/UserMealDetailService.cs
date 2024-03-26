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
    }
}
