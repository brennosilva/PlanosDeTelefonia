using FluentNHibernate.Mapping;
using PlanosDeTelefonia.Dominio.Entidades;

namespace PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento
{
    public class DDDMap : ClassMap<DDD>
    {
        public DDDMap()
        {
            Table("");
            Id(x => x.CodigoDDD).Column("");
        }
    }
}