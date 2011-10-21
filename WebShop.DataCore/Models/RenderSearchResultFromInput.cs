using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Components.DictionaryAdapter;
using NHibernate.Linq;

namespace WebShop.DataCore.Models
{
    public class RenderSearchResultFromInput
    {



        public RenderSearchResultFromInput()
        {

        }

        public List<Product> RenderResult(string searchstring)
        {

            var searchResults = new List<Product>();

            if (string.IsNullOrEmpty(searchstring) || searchstring == " ")
                return searchResults;


            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();
            var result = session.Query<Product>().ToList();
            var list = (from product in result
                        where product.Name.ToLower().Contains(searchstring.ToLower())
                        || product.Brand.ToLower().Contains(searchstring.ToLower())
                        select product).ToList();

            return list;
        }
        public static void PutSearchInDB(Guid id, string searchString)
        {

            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();

            var search = new Search();

            search.GuidId = id;
            search.SearchString = searchString;
            search.Time = DateTime.Now;
            session.Save(search);

            //session.SaveOrUpdate(search);
            session.Flush();
            session.Close();
            session.Dispose();




        }
    }
}
