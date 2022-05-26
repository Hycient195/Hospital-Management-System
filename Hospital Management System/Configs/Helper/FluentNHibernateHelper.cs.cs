using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;


namespace Hospital_Management_System.Configs.Helper
{
    public static class FluentNHibernameHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if(_sessionFactory is null)
                {
                    InitialiseSessionFactory();
                }
                return _sessionFactory;
            }
            set
            {

            }
        }

        public static void InitialiseSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\GroupSchoolModel.mdf;Integrated Security=True;Connect Timeout=30"))
                .Mappings(perEntity => perEntity.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(config => new SchemaExport(config).Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public static ISession CloseSession()
        {
            return null;
        }
    }
}
