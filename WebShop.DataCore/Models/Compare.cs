using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using WebShop.DataCore.Models;

namespace WebShop.DataCore.Models
{
    public class Compare
    {
        private List<Product> productList;

        public Compare()
        {

        }


        public List<Product> GetCompareProductList(int[] inList) {

            productList = new List<Product>();

            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();
            foreach (var item in inList)
            {

                var product = session.Get<Product>(item);
                productList.Add(product);

            }
            var list = session.Query<Product>().ToList();
           

            
            session.Close();
            session.Dispose();

            



            return productList;

            

        }
    }
}
