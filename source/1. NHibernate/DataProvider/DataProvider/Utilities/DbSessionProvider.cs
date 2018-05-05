using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Web;

namespace DataProvider.Utilities
{
    public class DbSessionProvider
    {
        private static ISessionFactory sessionFactory = null;

        public static void Configure()
        {
            sessionFactory = CreateSessionFactory();
        }

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                    Configure();
                return sessionFactory;
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var config = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(
                    "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TestDb; Integrated Security=True"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DbSessionProvider>())
                .BuildConfiguration();
            var schemaExport = new SchemaExport(config);
            schemaExport.Create(false, true);

            return config.BuildSessionFactory();
        }

        public static ISession CurrentSession
        {
            get
            {
                if (DbSession == null)
                {
                    DbSession = SessionFactory.OpenSession();
                    DbSession.FlushMode = FlushMode.Commit;
                }
                return DbSession;
            }
        }

        private static ISession DbSession { get; set; }
    }
}