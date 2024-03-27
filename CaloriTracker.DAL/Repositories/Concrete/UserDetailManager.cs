using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.Repositories.Concrete
{
    public class UserDetailManager:Crud<UserDetail>
    {
        public UserDetailManager(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        AppDbContext _dbContext;

        public UserTypes GetUserType(int id)
        {
            var user = _dbContext.Users.Where(x=>x.ID == id).FirstOrDefault();
            return user.UserType;
        }

        
    }
}
