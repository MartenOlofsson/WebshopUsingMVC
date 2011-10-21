//using System;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using NHibernate.Linq;
//using WebShop.DataCore;
//using WebShop.DataCore.Models;

//namespace consoleApp
//{
//    public class PopulateProductListMain
//    {



//        public static void Main(string[] args)
//        {


//            var session = RepositoryConfiguration.GetSessionFactory().OpenSession();

//            session.SaveOrUpdate(new Product() { Name = "Lasse" });
//            session.SaveOrUpdate(new Product() { Name = "Pelle" });
//            session.Flush();

//            var result = session.Query<Product>().ToList();

//            session.Close();

//            session.Dispose();
//            Console.WriteLine("Databasen är populerad");

//        }
//    }
//}
