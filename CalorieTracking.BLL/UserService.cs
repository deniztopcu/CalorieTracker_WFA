using CaloriTracker.DAL.Repositories.Concrete;
using CaloriTracker.DAL;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CalorieTracking.BLL
{
    public class UserService
    {
        public UserService()
        {
            userManager = new UserManager(new AppDbContext());
        }

        UserManager userManager;

        public bool Add(User user)
        {
            user.CreationDate = DateTime.Now;
            user.Status = Status.Active;
            return userManager.Add(user);
        }

        public bool Update(User user)
        {
            user.ModifiedDate = DateTime.Now;
            user.Status = Status.Modified;
            return userManager.Update(user);
        }

        public bool Delete(int id)
        {
            User user = GetById(id);
            return userManager.Delete(user);
        }

        public User GetById(int id)
        {
            return userManager.Find(id);
        }

        public User ControlUser(string username, string password)
        {

            var user = userManager.GetUserByLogin(username, password);

            if (user != null)
                return user;
            return null;
        }

        public bool ControlEmail(string email)
        {
            if(email==userManager.GetEmail(email)) 
                return false;
            else return true;
        }

        public string SendPasswordClue(string email)
        {
            string clue = userManager.GetPasswordClue(email);
            return clue;

        }
        public List<User> GetUsers()
        {
            return userManager.GetUsers();
        }

    }
}

