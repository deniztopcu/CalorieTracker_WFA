using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class User : BaseEntity
    {

        public User()
        {
            UserType = UserTypes.NormalUser;
        }
        public UserTypes UserType { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }

        public string    PasswordClue { get; set; }

        public ICollection<Food> Foods { get; set; }    
        public UserDetail? UserDetail { get; set; }
        public ICollection <Meal> Meals { get; set; }
        public ICollection<UserMealDetail> UserMealDetails { get; set; }
    }
}
