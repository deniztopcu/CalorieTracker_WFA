using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstract;
using Models.Enums;

namespace Models.Concrete
{
    public class Meal : BaseEntity
    {
        //[ForeignKey("User")]
        //public int ID {  get; set; }
        public MealTypes MealType { get; set; }



        //[ForeignKey("User")]

        //public int UserID { get; set; }
        //public User? User { get; set; }

        public ICollection<UserMealDetail> UserMealDetails { get; set; }

        public override string ToString()
        {
            return MealType.ToString();
        }
    }
}
