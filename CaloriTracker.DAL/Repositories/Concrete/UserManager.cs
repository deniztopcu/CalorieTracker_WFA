using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.Repositories.Concrete
{
    public class UserManager : Crud<User>
    {
        public UserManager(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public AppDbContext _dbContext;

        public User GetUserByLogin(string email,string password)
        {
            return _dbContext.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();               
        }

        
        public string GetEmail(string email)
        {

            var user= _dbContext.Users.Where(x => x.Email == email).FirstOrDefault();
            if (user != null)
            {
                return user.Email;
            }
            else
                return null;
            
        }

        public string GetPasswordClue(string email)
        {
            var user = _dbContext.Users.Where(x =>x.Email == email).FirstOrDefault();
            if (user != null)
            {
                return user.PasswordClue;
            }
            else
                return null;
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User CheckInfo(string email, string ipucu)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email == email && u.PasswordClue == ipucu);
        }

        public User UserByUserId(int userId)
        {
            return _dbContext.Users.FirstOrDefault(x => x.ID == userId);
        }

        public User CheckInfo(string email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email == email);
        }
    }
}
