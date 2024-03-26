using Models.Concrete;
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

      
    }
}
