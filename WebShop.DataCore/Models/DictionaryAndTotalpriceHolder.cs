using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebShop.DataCore.Models
{
    public class DictionaryAndTotalpriceHolder
    {
        public Dictionary<Product, CartOutputModel> dictionary { get; set; }
        public double Amount { get; set; }


        public DictionaryAndTotalpriceHolder()
        {
             dictionary = new Dictionary<Product, CartOutputModel>();
        }
       

    }
}
