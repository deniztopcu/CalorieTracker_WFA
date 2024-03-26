using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Food:BaseEntity
    {
        public string Name { get; set; }
        public double Calorie { get; set; }
        public PortionNames PortionName { get; set; }
        public double PortionGram { get; set; }
        public string Picture { get; set; }

        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<UserMealDetail> UserMealDetails { get; set; }

    }
}
