using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopUsingMvc.Models
{
    public class CompareInputModel
    {
        public List<int> ProductIds { get; set; }


        public CompareInputModel()
        {
            ProductIds = new List<int>();
        }
    }

}