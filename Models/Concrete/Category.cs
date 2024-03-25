using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Food>? Foods { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
