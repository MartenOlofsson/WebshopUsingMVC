using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace WebShop.DataCore.Models
{
    public class SubCategory
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual IList<Product> ProductList { get; set; }


    }
}
