using Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class UserMealDetail:BaseEntity
    {

        public int FoodCount { get; set; }
        public double TotalCalorie { get; set; }

        public int UserID { get; set; }
        public User? User { get; set; }

        //[ForeignKey("Food")]
        public int FoodID { get; set; }
        public Food? Food { get; set; }

        //[ForeignKey("Meal")]
        public int MealID { get; set; }
        public Meal? Meal { get; set; }
    }
}
