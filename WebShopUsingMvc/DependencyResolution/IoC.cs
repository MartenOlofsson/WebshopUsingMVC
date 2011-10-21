using StructureMap;
using NHibernate;
using WebShop.DataCore;


namespace WebShopUsingMvc {
    public static class IoC {


        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });

                            x.For<ISessionFactory>().Singleton().Use(RepositoryConfiguration.GetSetupSessionFactory());
                            x.For<ISession>().HybridHttpOrThreadLocalScoped().Use(y => y.GetInstance<ISessionFactory>().OpenSession());
                            
                        });
            return ObjectFactory.Container;
        }
    }
}