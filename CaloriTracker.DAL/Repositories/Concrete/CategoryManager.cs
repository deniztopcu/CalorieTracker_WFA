using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.Repositories.Concrete
{
    public class CategoryManager : Crud<Category>
    {
        public CategoryManager(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        AppDbContext _dbContext;



    }   
}
