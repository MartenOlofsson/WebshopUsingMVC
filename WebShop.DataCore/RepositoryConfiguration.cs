using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using WebShop.DataCore.Models;

namespace WebShop.DataCore
{
    public class RepositoryConfiguration
    {
        private static ISessionFactory sessionFactory;
        public static ISessionFactory GetSessionFactory()
        {
            if (sessionFactory != null)
                return sessionFactory;

            sessionFactory = Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        c => c.FromConnectionStringWithKey("ApplicationServices")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Product>()).BuildSessionFactory();

            return sessionFactory;

        }
        public static ISessionFactory GetSetupSessionFactory()
        {
            

            sessionFactory = Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        c => c.FromConnectionStringWithKey("ApplicationServices")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Product>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();

            return sessionFactory;

        }
      
    }
}
