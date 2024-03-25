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
    public class UserDetail : BaseEntity
    {
        

        public string Name { get; set; }

        public string Surname { get; set; }

        public double Weight { get; set; }

        public int Height { get; set; }

        public DateTime BirthDate { get; set; }

        public Genders Gender { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; } 
        public User? User { get; set; }



    }
}
