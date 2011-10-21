
using System.Collections.Generic;

namespace WebShop.DataCore.Models
{
    public class Category
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<SubCategory> ListOfSubCategories { get; set; }
        public virtual string CategoryPicture { get; set; }
        public virtual string Class { get; set; }

    }
}


