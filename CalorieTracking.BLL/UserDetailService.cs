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
    public class UserDetailService
    {
        public UserDetailService()
        {
            userDetailManager = new UserDetailManager(new AppDbContext());
        }

        UserDetailManager userDetailManager;

        public bool Add(UserDetail userDetail)
        {
            userDetail.CreationDate = DateTime.Now;
            userDetail.Status = Status.Active;
            return userDetailManager.Add(userDetail);
        }

        public bool Update(UserDetail userDetail)
        {
            userDetail.ModifiedDate = DateTime.Now;
            userDetail.Status = Status.Modified;
            return userDetailManager.Update(userDetail);
        }

        public bool Delete(int id)
        {
            UserDetail userDetail = GetById(id);
            return userDetailManager.Delete(userDetail);
        }

        public UserDetail GetById(int id)
        {
            return userDetailManager.Find(id);
        }

        public bool UserTypeControl(int id)
        {
            if(userDetailManager.GetUserType(id) == UserTypes.Admin)
            return true;
            else return false;
        }
    }
}
