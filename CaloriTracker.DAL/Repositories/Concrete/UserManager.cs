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

        //private string Md5(string sifre)
        //{
        //    MD5 md5 = MD5.Create();
        //    byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(sifre));

        //    string str = "";
        //    foreach (byte b in hash)
        //    {
        //        str += b.ToString("x2");

        //    }
        //    return str;
        //

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
    }
}
