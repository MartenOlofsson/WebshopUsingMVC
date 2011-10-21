using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebShop.DataCore.Models
{
    public class ProductsOnCampaign
    {
        public virtual int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual double CampaginPrice { get; set; }
        public virtual DateTime StartTime { get; set; }



    }
}
