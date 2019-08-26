using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento;

namespace PlanosDeTelefonia.Infraestrutura.NHibernate
{
    public class NhibernateHelper
    {
        public static ISession OpenSession(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Plano");
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(OracleManagedDataClientConfiguration.Oracle10.ConnectionString(connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PlanoMap>())
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}